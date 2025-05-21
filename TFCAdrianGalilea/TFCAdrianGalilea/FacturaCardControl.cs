using iTextSharp.text.pdf;
using iTextSharp.text;
using Manejo.EntidadesDTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf.draw;

namespace TFCAdrianGalilea
{
    public class FacturaCardControl : UserControl
    {
        public event EventHandler<int> EditarClick;
        public event EventHandler<int> EliminarClick;

        private Label lblIdFactura;
        private Label lblFecha;
        private Label lblDniCliente;
        private Label lblIdReparacion;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnImprimir;

        private FacturaDTO factura;

        public FacturaCardControl(FacturaDTO factura)
        {
            this.factura = factura;
            InitializeComponents();
            MostrarDatos();
        }

        private void InitializeComponents()
        {
            this.Size = new Size(300, 150);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(23, 24, 29);

            lblIdFactura = new Label { Location = new Point(10, 10), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblFecha = new Label { Location = new Point(10, 30), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblDniCliente = new Label { Location = new Point(10, 50), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };
            lblIdReparacion = new Label { Location = new Point(10, 70), AutoSize = true, ForeColor = Color.White, BackColor = Color.Transparent };

            btnEditar = new Button
            {
                Text = "Editar",
                Location = new Point(10, 100),
                Size = new Size(80, 30),
                ForeColor = Color.White,
            };

            btnEliminar = new Button
            {
                Text = "Eliminar",
                Location = new Point(100, 100),
                Size = new Size(80, 30),
                BackColor = Color.LightCoral
            };

            btnImprimir = new Button
            {
                Text = "Imprimir",
                Location = new Point(190, 100),
                Size = new Size(80, 30),
                BackColor = Color.LightGreen
            };

            btnEditar.Click += (s, e) => EditarClick?.Invoke(this, factura.IdFacturaDTO);
            btnEliminar.Click += (s, e) => EliminarClick?.Invoke(this, factura.IdFacturaDTO);
            btnImprimir.Click += (s, e) => ImprimirFacturaPDF();

            this.Controls.AddRange(new Control[] {
                lblIdFactura, lblFecha, lblDniCliente, lblIdReparacion,
                btnEditar, btnEliminar, btnImprimir
            });
        }


        private void MostrarDatos()
        {
            lblIdFactura.Text = $"ID Factura: {factura.IdFacturaDTO}";
            lblFecha.Text = $"Fecha: {factura.FechaDTO.ToShortDateString()}";
            lblDniCliente.Text = $"DNI Cliente: {factura.DniClienteDTO}";

            if (factura.ReparacionDTO != null)
            {
                lblIdReparacion.Text = $"ID Reparación: {factura.IdReparacionDTO} - {factura.ReparacionDTO.ModeloVehiculoDTO}";

            }
            else
            {
                lblIdReparacion.Text = $"ID Reparación: {factura.IdReparacionDTO}";
            }
        }
        private void ImprimirFacturaPDF()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, $"Factura_{factura.IdFacturaDTO}.pdf");

                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                using (Document doc = new Document(PageSize.A4, 50, 50, 60, 60))
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    string logoPath = Path.Combine(Application.StartupPath, "TFCAdrianGalilea\\Resources\\Reparaciones (1).png");
                    if (File.Exists(logoPath))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                        logo.ScaleToFit(120f, 120f);
                        logo.Alignment = Element.ALIGN_LEFT;
                        doc.Add(logo);
                    }

                    Paragraph empresa = new Paragraph("Taller Mecánico Reparaciones Gorostiaga\nCIF: A12345678\nPolígono Industrial la Portalada, Av. Aragón, 44, 26006 Varea, La Rioja\nTel: 941234003\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                    empresa.Alignment = Element.ALIGN_LEFT;
                    doc.Add(empresa);

                    doc.Add(new LineSeparator(1f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, -2));

                    Paragraph titulo = new Paragraph("FACTURA", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.SpacingAfter = 20f;
                    doc.Add(titulo);

                    PdfPTable tablaFactura = new PdfPTable(2);
                    tablaFactura.WidthPercentage = 100;
                    tablaFactura.SpacingAfter = 10f;
                    tablaFactura.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                    tablaFactura.AddCell("N° Factura:");
                    tablaFactura.AddCell(factura.IdFacturaDTO.ToString());

                    tablaFactura.AddCell("Fecha:");
                    tablaFactura.AddCell(factura.FechaDTO.ToShortDateString());

                    doc.Add(tablaFactura);

                    Paragraph datosCliente = new Paragraph("Datos del Cliente", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                    datosCliente.SpacingBefore = 10f;
                    datosCliente.SpacingAfter = 5f;
                    doc.Add(datosCliente);

                    PdfPTable tablaCliente = new PdfPTable(2);
                    tablaCliente.WidthPercentage = 100;
                    tablaCliente.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                    tablaCliente.AddCell("DNI:");
                    tablaCliente.AddCell(factura.DniClienteDTO);

                    doc.Add(tablaCliente);

                    if (factura.ReparacionDTO != null)
                    {
                        Paragraph datosReparacion = new Paragraph("Detalle de Reparación", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                        datosReparacion.SpacingBefore = 15f;
                        datosReparacion.SpacingAfter = 5f;
                        doc.Add(datosReparacion);

                        PdfPTable tablaReparacion = new PdfPTable(2);
                        tablaReparacion.WidthPercentage = 100;
                        tablaReparacion.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                        tablaReparacion.AddCell("ID Reparación:");
                        tablaReparacion.AddCell(factura.ReparacionDTO.IdReparacionDTO.ToString());

                        tablaReparacion.AddCell("Vehículo:");
                        tablaReparacion.AddCell($"{factura.ReparacionDTO.ModeloVehiculoDTO} - {factura.ReparacionDTO.MatriculaVehiculoDTO}");

                        tablaReparacion.AddCell("Descripción:");
                        tablaReparacion.AddCell(factura.ReparacionDTO.DescripcionDTO);

                        tablaReparacion.AddCell("Precio:");
                        tablaReparacion.AddCell($"{factura.ReparacionDTO.PrecioDTO:C}");

                        doc.Add(tablaReparacion);
                    }

                    Paragraph pie = new Paragraph("\nGracias por confiar en nosotros.", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10));
                    pie.Alignment = Element.ALIGN_CENTER;
                    pie.SpacingBefore = 30f;
                    doc.Add(pie);

                    doc.Close();
                }

                MessageBox.Show("Factura generada correctamente en el escritorio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}");
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Name = "FacturaCardControl";
            this.ResumeLayout(false);

        }
    }
}
