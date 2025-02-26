using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_BaseForms;

namespace AVISC_EdiTools
{
    public partial class EDI : AVISC_CloseableFeatureForm
    {
        SecureCoreG5Entities sc;
        List<Orders> orders;
        List<Priority> priority;
        List<OperationalAreas> operationalAreas;
        List<Agencies> agencies;
        List<Factories> factories;
        List<OrderInfo> orderInfo;
        List<OrdersDetail> ordersDetail;
        List<Planets> planets;
        List<References> references;
        public EDI()
        {
            InitializeComponent();
        }

        private void swTextButton1_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();

                sc = new SecureCoreG5Entities();
                orders = new List<Orders>();
                priority = new List<Priority>();
                operationalAreas = new List<OperationalAreas>();
                agencies = new List<Agencies>();
                factories = new List<Factories>();
                orderInfo = new List<OrderInfo>();
                ordersDetail = new List<OrdersDetail>();
                planets = new List<Planets>();
                references = new List<References>();            

                string[] docRead = File.ReadAllLines(openFileDialog.FileName);

                bool correcte = false;

                if (openFileDialog.FileName.Length > 0)
                {
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        foreach (string line in docRead)
                        {
                            List<string> parts = line.Split('|').ToList();
                            int cantidad;
                            
                            if (parts[0] == "ORDERS_D_96A_UN_EAN008")
                            {
                                correcte = true;
                            }
                            else
                            {
                                if (correcte)
                                {
                                    if (parts[0] == "ORD")
                                    {
                                        orders.Add(new Orders { codeOrder = parts[1] });

                                        priority.Add(new Priority { idPriority = orders[0].IdFactory, DescPriority = parts[2] });

                                        sc.Priority.AddRange(priority);
                                    }

                                    ordersDetail.Add(new OrdersDetail { idOrder = orders[0].idOrder });
                                    orderInfo.Add(new OrderInfo { idOrder = orders[0].idOrder });

                                    if (parts[0] == "DTM")
                                    {
                                        orders.Add(new Orders { idOrder = orders[0].idOrder, dateOrder = DateTime.ParseExact(parts[1], "yyyyMMdd", CultureInfo.InvariantCulture) });
                                    }
                                    else if (parts[0] == "NADMS")
                                    {
                                        agencies.Add(new Agencies { idAgency = orderInfo[0].idAgency, DescAgency = parts[2] });
                                        operationalAreas.Add(new OperationalAreas { idOperationalArea = orderInfo[0].idOperationalArea, DescOperationalArea = parts[1] });

                                        sc.Agencies.AddRange(agencies);
                                        sc.OperationalAreas.AddRange(operationalAreas);
                                    }
                                    else if (parts[0] == "NADMR")
                                    {
                                        factories.Add(new Factories { idFactory = orders[0].IdFactory, codeFactory = parts[1] });

                                        sc.Factories.AddRange(factories);
                                    }
                                    else if (parts[0] == "LIN")
                                    {
                                        OrdersDetail newOrderDetail = new OrdersDetail { idOrder = orders[0].idOrder };
                                        ordersDetail.Add(newOrderDetail);

                                        Planets newPlanet = new Planets { CodePlanet = parts[1] };
                                        planets.Add(newPlanet);

                                        References newReference = new References { codeReference = parts[2] };
                                        references.Add(newReference);

                                        sc.Planets.AddRange(planets);
                                        sc.References.AddRange(references);
                                    }
                                    else if (parts[0] == "QTYLIN")
                                    {
                                        if (parts[1] == "61")
                                        {
                                            cantidad = (int.Parse(parts[2]) * (-1));
                                        }
                                        else
                                        {
                                            cantidad = int.Parse(parts[2]);
                                        }

                                        ordersDetail.Add(new OrdersDetail { idOrder = orders[0].idOrder, Quantity = (short)cantidad });
                                    }
                                    else if (parts[0] == "DTMLIN")
                                    {
                                        ordersDetail.Add(new OrdersDetail { idOrder = orders[0].idOrder, DeliveryDate = DateTime.ParseExact(parts[1], "yyyyMMdd", CultureInfo.InvariantCulture) });
                                    }
                                }
                            }
                            txt_Edi.Text += line + "\r\n";
                        }
                        sc.Orders.AddRange(orders);
                        sc.OrderInfo.AddRange(orderInfo);
                        sc.OrdersDetail.AddRange(ordersDetail);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void swTextButton2_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                sc.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

    }
}