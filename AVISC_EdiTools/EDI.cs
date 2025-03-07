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
using AVISC_DatabaseModel;

namespace AVISC_EdiTools
{
    public partial class EDI : AVISC_CloseableFeatureForm
    {
        SecureCoreEF sc;

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
                sc = new SecureCoreEF();
                orders = new Orders();
                orderInfo = new OrderInfo();
                ordersDetail = new OrdersDetail();

                orderInfo.idOrder = orders.idOrder;
                ordersDetail.idOrder = orders.idOrder;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();

                string[] docRead = File.ReadAllLines(openFileDialog.FileName);

                if (openFileDialog.FileName.Contains(".edi"))
                {
                    bool correcte = false;

                    lbl_edi.Visible = true;
                    lbl_edi.ForeColor = Color.White;
                    lbl_edi.Text = "Archivo EDI selecionado";

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

                                        txt_Edi.Text += line + "\r\n";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    lbl_edi.Visible = true;
                    lbl_edi.ForeColor = Color.Red;
                    lbl_edi.Text = "Selecciona un archivo .edi";
                }
            }
            catch (Exception)
            {
                lbl_edi.Visible = true;
                lbl_edi.ForeColor = Color.Red;
                lbl_edi.Text = "No has seleccionado un .edi";
            }
        }

        private void swTextButton2_ButtonClick(object sender, EventArgs e)
        {
            try
            {

                if (sc.Orders.Any(c => c.codeOrder == orders.codeOrder))
                {
                    lbl_bbd.Visible = true;
                    lbl_bbd.ForeColor = Color.Red;
                    lbl_bbd.Text = "Codigo de orden duplicado";
                }
                else
                {
                    sc.Orders.Add(orders);
                    //sc.OrdersDetail.Add(ordersDetail); 
                    sc.OrderInfo.Add(orderInfo);

                    sc.SaveChanges();
                    lbl_bbd.Visible = true;
                    lbl_bbd.ForeColor = Color.White;
                    lbl_bbd.Text = "Los datos se han subido correctamente!";
                }
            }
            catch (Exception ex)
            {
                lbl_bbd.Visible = true;
                lbl_bbd.ForeColor = Color.Red;
                lbl_bbd.Text = $"Ha habido un error al subir los datos: {ex.Message}";
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

            orders.OrdersDetail.Add(new OrdersDetail()
                {
                    idOrder = orders.idOrder,
                    idPlanet = sc.Planets.FirstOrDefault(p => p.CodePlanet == idPlanet).idPlanet,
                    idReference = sc.References.FirstOrDefault(r => r.codeReference == idReference).idReference,
                }
            );

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

            orders.OrdersDetail.LastOrDefault().Quantity = (short)cantidad;
        }
        private void GuardarDatosDTMLIN(List<string> parts)
        {
            orders.OrdersDetail.LastOrDefault().DeliveryDate = DateTime.ParseExact(parts[1], "yyyyMMdd", CultureInfo.InvariantCulture);
        }
    }
}