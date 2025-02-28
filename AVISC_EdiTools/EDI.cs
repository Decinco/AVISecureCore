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

        Orders orders;
        OrderInfo orderInfo ;
        OrdersDetail ordersDetail;

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
                orders = new Orders();
                orderInfo = new OrderInfo();
                ordersDetail = new OrdersDetail();

                string[] docRead = File.ReadAllLines(openFileDialog.FileName);

                bool correcte = false;

                if (openFileDialog.FileName.Length > 0)
                {
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        foreach (string line in docRead)
                        {
                            List<string> parts = line.Split('|').ToList();

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
                                        GuardarDatosORD(parts);
                                    }
                                    else if (parts[0] == "DTM")
                                    {

                                        GuardarDatosDTM(parts);
                                    }
                                    else if (parts[0] == "NADMS")
                                    {
                                        GuardarDatosNADMS(parts);
                                    }
                                    else if (parts[0] == "NADMR")
                                    {
                                        GuardarDatosNADMR(parts);
                                    }
                                    else if (parts[0] == "LIN")
                                    {
                                        GuardarDatosLIN(parts);
                                    }
                                    else if (parts[0] == "QTYLIN")
                                    {
                                        GuardarDatosQTYLIN(parts);
                                    }
                                    else if (parts[0] == "DTMLIN")
                                    {
                                        GuardarDatosDTMLIN(parts);
                                    }
                                }
                            }
                            txt_Edi.Text += line + "\r\n";
                        }
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
                orderInfo.idOrder = orders.idOrder;
                ordersDetail.idOrder = orders.idOrder;

                sc.Orders.Add(orders);
                sc.OrdersDetail.Add(ordersDetail);
                sc.OrderInfo.Add(orderInfo);

                sc.SaveChanges();
                MessageBox.Show($"Se subio correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void GuardarDatosORD(List<string> parts)
        {
            orders.codeOrder = parts[1];

            string idPriority = parts[2];
            orders.IdPriority = sc.Priority.FirstOrDefault(x => x.CodePriority == idPriority).idPriority;
        }

        private void GuardarDatosDTM(List<string> parts)
        {
            orders.dateOrder = DateTime.ParseExact(parts[1], "yyyyMMdd", CultureInfo.InvariantCulture);
        }

        private void GuardarDatosNADMS(List<string> parts)
        {
            string idAgency = parts[2];
            string idOperationalArea = parts[1];

            orderInfo.idAgency = sc.Agencies.FirstOrDefault(a => a.CodeAgency == idAgency).idAgency;

            orderInfo.idOperationalArea = sc.OperationalAreas.FirstOrDefault(opA => opA.CodeOperationalArea == idOperationalArea).idOperationalArea;
        }
        private void GuardarDatosNADMR(List<string> parts)
        {
            string idFactory = parts[1];

            orders.IdFactory = sc.Factories.FirstOrDefault(f => f.codeFactory == idFactory).idFactory;
        }
        private void GuardarDatosLIN(List<string> parts)
        {
            string idPlanet = parts[1];
            string idReference = parts[2];

            ordersDetail.idPlanet = sc.Planets.FirstOrDefault(p => p.CodePlanet == idPlanet).idPlanet;

            ordersDetail.idReference = sc.References.FirstOrDefault(r => r.codeReference == idReference).idReference;
        }
        private void GuardarDatosQTYLIN(List<string> parts)
        {
            int cantidad;
            if (parts[1] == "61")
            {
                cantidad = (int.Parse(parts[2]) * (-1));
            }
            else
            {
                cantidad = int.Parse(parts[2]);
            }

            ordersDetail.Quantity = (short)cantidad;

        }
        private void GuardarDatosDTMLIN(List<string> parts)
        {
            ordersDetail.DeliveryDate = DateTime.ParseExact(parts[1], "yyyyMMdd", CultureInfo.InvariantCulture);
        }
    }
}