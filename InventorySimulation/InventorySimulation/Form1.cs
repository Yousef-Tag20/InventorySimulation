using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventoryTesting;
using InventoryModels;
using System.IO;

namespace InventorySimulation

{
    public partial class Form1 : Form
    {
        readonly SimulationSystem sys = new SimulationSystem();
        readonly Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            #region Input

            var sr = new StreamReader("tt.txt");
            

            //Fetching Input
            var queue = new Queue<int>();
            for (int i = 0; i < 6; i++)
                queue.Enqueue(int.Parse(sr.ReadLine()));
            sys.OrderUpTo = queue.Dequeue();
            sys.ReviewPeriod = queue.Dequeue();
            sys.NumberOfDays = queue.Dequeue();
            sys.StartInventoryQuantity = queue.Dequeue();
            sys.StartLeadDays = queue.Dequeue();
            sys.StartOrderQuantity = queue.Dequeue();

            //Read demand list
            sys.DemandDistribution = FetchList(ref sr, 5, 100);

            //Read leading list
            sys.LeadDaysDistribution = FetchList(ref sr, 3, 10);

            sr.Close();
        #endregion
            SimulationCase sc, prev = null;
            int order = sys.StartOrderQuantity;
            bool isLast;
            for (int days = 1; days <= sys.NumberOfDays; days++)
            {
                isLast = days % sys.ReviewPeriod == 0;
                sc = new SimulationCase()
                {
                    Day = days,
                    Cycle = days / sys.ReviewPeriod + 1,
                    DayWithinCycle = (days % sys.ReviewPeriod),
                    BeginningInventory = (days > 1) ?
                        prev.EndingInventory : sys.StartInventoryQuantity,
                    RandomDemand = r.Next(1, 100),
                    //Demand
                    //Ending Inventory
                    ShortageQuantity = (days > 1) ?
                        prev.ShortageQuantity : 0,
                    OrderQuantity = 0,
                    RandomLeadDays = (isLast) ? r.Next(1, 10) : 0,
                    LeadDays = 0,
                    DaysUntilOrderArrives = (days > 1) ? prev.DaysUntilOrderArrives - 1 : sys.StartLeadDays - 1
                };
                //Demand for the day
                sc.Demand = GetValue(sys.DemandDistribution, sc.RandomDemand);

                if (sc.DaysUntilOrderArrives == -1) //The day the order arrives
                {
                    sc.BeginningInventory += order;
                    // bi = 5, sq = 3 ,3-5 = -2
                    sc.ShortageQuantity -= sc.BeginningInventory;
                    if (sc.ShortageQuantity < 0)
                    {
                        sc.EndingInventory = -1 * sc.ShortageQuantity - sc.Demand;
                        sc.ShortageQuantity = 0;
                    }
                    else // Shoratge is greater than recieved order
                    {
                        sc.EndingInventory -= sc.ShortageQuantity + sc.Demand;
                    }
                }
                else // Any other day
                    sc.EndingInventory = sc.BeginningInventory - sc.Demand;

                if (sc.EndingInventory < 0) //Demand is higher than Begining inventory
                {
                    sc.ShortageQuantity += sc.EndingInventory * -1;
                    sc.EndingInventory = 0;
                }
                else
                    sc.ShortageQuantity = 0;

                if (isLast) // Last day in the cycle
                {
                    sc.DayWithinCycle=sys.ReviewPeriod;
                    sc.Cycle--;
                    order = sc.OrderQuantity = sys.OrderUpTo - sc.EndingInventory + sc.ShortageQuantity;
                    sc.DaysUntilOrderArrives = sc.LeadDays = 1;// GetValue(sys.LeadDaysDistribution, sc.RandomLeadDays);
                }


                prev = sc;
                sys.SimulationCases.Add(sc);
            }
            #region Output
            decimal endingInventory = 0, shortageQuantity = 0;
            foreach (var x in sys.SimulationCases)
            {
                endingInventory+=x.EndingInventory;
                shortageQuantity+=x.ShortageQuantity;
                var row = new int[] { x.Day, x.Cycle, x.DayWithinCycle, x.BeginningInventory, x.RandomDemand, x.Demand, x.EndingInventory,
                    x.ShortageQuantity, x.OrderQuantity, x.RandomLeadDays, x.LeadDays,
                    (x.DaysUntilOrderArrives<0) ? 0 : x.DaysUntilOrderArrives };
                var update = Array.ConvertAll(row, s => s.ToString());
                dataGridView1.Rows.Add(update);
                
            }
            var rr = new string[12];
            rr[0] = "Total";
            rr[6] = endingInventory.ToString();
            rr[7] = shortageQuantity.ToString();
            dataGridView1.Rows.Add(rr);

            sys.PerformanceMeasures.EndingInventoryAverage = endingInventory / sys.NumberOfDays;
            sys.PerformanceMeasures.ShortageQuantityAverage = shortageQuantity/ sys.NumberOfDays;

            rr[0] = "Average";
            rr[6] = sys.PerformanceMeasures.EndingInventoryAverage.ToString();
            rr[7] = sys.PerformanceMeasures.ShortageQuantityAverage.ToString();
            dataGridView1.Rows.Add(rr);
            #endregion
        }
        private List<Distribution> FetchList(ref StreamReader sr, int iterations, int maxRange)
        {
            var distributions = new List<Distribution>();
            string[] line;
            int val;
            decimal prop;
            Distribution dis, prevD = null;
            for (int i = 0; i < iterations; i++)
            {
                line = sr.ReadLine().Split(' ');
                val = int.Parse(line[0]);
                prop = decimal.Parse(line[1]);
                dis = new Distribution()
                {
                    Probability = prop,
                    CummProbability = prop,
                    Value = val,
                };
                if (i == 0)
                {
                    dis.MinRange = 1;
                    dis.MaxRange = (int)(prop * maxRange);
                }
                else
                {
                    dis.CummProbability += prevD.CummProbability;
                    dis.MinRange = prevD.MaxRange + 1;
                    dis.MaxRange = (int)(dis.CummProbability * maxRange);
                }
                prevD = dis;
                distributions.Add(dis);
            }
            return distributions;
        }
        private int GetValue(List<Distribution> distributions, int randomDemand)
        {
            foreach (var x in distributions)
                if (randomDemand >= x.MinRange && randomDemand <= x.MaxRange)
                    return x.Value;
            throw new Exception("Unrecognized");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var test = TestingManager.Test(sys, Constants.FileNames.TestCase1);
            MessageBox.Show(test);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}