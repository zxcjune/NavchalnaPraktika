using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using TicketsLib;
using RouteLib;

namespace PDFExporterCustom
{

    public class PDFExporter
    {
        public static void ExportTicketsToPDF(List<Ticket> tickets, string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(7);
            table.AddCell("Ticket ID");
            table.AddCell("Route ID");
            table.AddCell("Passenger Name");
            table.AddCell("Destination");
            table.AddCell("Bus");
            table.AddCell("Driver Name");
            table.AddCell("Departure Time");

            foreach (var ticket in tickets)
            {
                table.AddCell(ticket.TicketId.ToString());
                table.AddCell(ticket.RouteId.ToString());
                table.AddCell(ticket.PassengerName);
                table.AddCell(ticket.Destination);
                table.AddCell(ticket.Bus);
                table.AddCell(ticket.DriverName);
                table.AddCell(ticket.DepartureTime.ToString("yyyy-MM-dd HH:mm"));
            }

            document.Add(table);
            document.Close();
        }
    }

}
