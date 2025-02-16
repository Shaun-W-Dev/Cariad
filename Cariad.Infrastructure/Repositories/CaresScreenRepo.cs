using Cariad.Application.Interfaces;
using Cariad.Domain.Models;

namespace Cariad.Infrastructure.Repositories
{
    public class CaresScreenRepo : ICaresScreensRepository
    {
        public async Task<IEnumerable<CaresScreenModel>> GetScreensAsync()
        {
            return await Task.FromResult(new List<CaresScreenModel> {
                new CaresScreenModel{Category = "Customer", Code = "CUS01", Title = "Customer details by customer number"},
                new CaresScreenModel{Category = "Customer", Code = "CUS1A", Title = "Create new customer record/ number"},
                new CaresScreenModel{Category = "Customer", Code = "CUS03", Title = "Customer index by surname/postcode"},
                new CaresScreenModel{Category = "Customer", Code = "CUS3A", Title = "Customer index by postcode and house number"},
                new CaresScreenModel{Category = "Customer", Code = "CUS3E", Title = "Customer search by full name and/or postcode"},
                new CaresScreenModel{Category = "Customer", Code = "CUS04", Title = "Customer account list using customer number"},
                new CaresScreenModel{Category = "Customer", Code = "CUS07", Title = "Customers relating to an account or loan number"},
                new CaresScreenModel{Category = "Savings", Code = "I2305", Title = "Savings account details"},
                new CaresScreenModel{Category = "Savings", Code = "I2308", Title = "Savings account transaction history"},
                new CaresScreenModel{Category = "Savings", Code = "I2137", Title = "Maturing account instructions details"},
                new CaresScreenModel{Category = "Savings", Code = "I2160", Title = "Change customers address"},
                new CaresScreenModel{Category = "Savings", Code = "I2110", Title = "Change number of signatures"},
                new CaresScreenModel{Category = "Savings", Code = "I2322", Title = "Cheque Number enquiry"},
                new CaresScreenModel{Category = "Savings", Code = "I2302", Title = "Interest earned to date"},
                new CaresScreenModel{Category = "Savings", Code = "I2303", Title = "List of no book transactions"},
                new CaresScreenModel{Category = "Savings", Code = "I2306", Title = "Shows where interest is paid"},
                new CaresScreenModel{Category = "Savings", Code = "I2132", Title = "Amend passbook audit number"},
                new CaresScreenModel{Category = "Savings", Code = "I2101", Title = "Change account status"},
                new CaresScreenModel{Category = "Savings", Code = "ISA10", Title = "ISA transfer screen"},
                new CaresScreenModel{Category = "Savings", Code = "STAND", Title = "Print a standing order form"},
                new CaresScreenModel{Category = "Savings", Code = "IBALL", Title = "Print balance letter"},
                new CaresScreenModel{Category = "Sole/Joint", Code = "CUS05", Title = "To add or remove a customer"},
                new CaresScreenModel{Category = "Sole/Joint", Code = "CUS06", Title = "To change voting rights and/or remove a customer"},
                new CaresScreenModel{Category = "Restrictions", Code = "CUS20", Title = "Add/remove RETM (returned mail) restriction"},
                new CaresScreenModel{Category = "Restrictions", Code = "CCR02", Title = "Remove CCR restriction"},
                new CaresScreenModel{Category = "Restrictions", Code = "IAS01", Title = "Remove LOSA restriction"},
                new CaresScreenModel{Category = "Tax Certificate", Code = "BRT04", Title = "Print tax certificate"},
                new CaresScreenModel{Category = "Deceased / Power of Attorney", Code = "ATT02", Title = "Register power of attorney"},
                new CaresScreenModel{Category = "Lost Passbooks", Code = "LSADD", Title = "Report passbook lost or stolen"},
                new CaresScreenModel{Category = "Lost Passbooks", Code = "LSINQ", Title = "Passbook audit trail"},
                new CaresScreenModel{Category = "Lost Passbooks", Code = "LSCHQ", Title = "Found passbook"},
                new CaresScreenModel{Category = "Lost Passbooks", Code = "IFEE1", Title = "Pay for lost passbook"},
                new CaresScreenModel{Category = "Cashier Screens", Code = "CSH01", Title = "Check cash order history"},
                new CaresScreenModel{Category = "Cashier Screens", Code = "CSH02", Title = "Order cash for the following day"},
                new CaresScreenModel{Category = "Cashier Screens", Code = "SUS83", Title = "check printer setup for branch"},
                new CaresScreenModel{Category = "Cashier Screens", Code = "ICALC", Title = "Interest calculator with list of accounts"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "ADM02", Title = "Mortgage main screen"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "MOR04", Title = "Mortgage enquiry menu"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "MOR01", Title = "Mortgage details"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "CUS07", Title = "Customers relating to loan number"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "CUS01", Title = "Primary customer details"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "INS01", Title = "Insurance details (if with RSA)"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "SEC01", Title = "Deeds diary (if held by PBS)"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "MOR02", Title = "Mortgage and property details"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "MOR03", Title = "Transaction history"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "MOR13", Title = "Rate change history"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "MOR23", Title = "Payment change history"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "MOR6A", Title = "Out of penalty check"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "PEN02", Title = "How much penalty to redeem mortgage"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "MOR32", Title = "Accept/Decline for further lending"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "CALC1", Title = "Calculate monthly repayments"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "DDS02", Title = "Set up/amend mortgage direct debit"},
                new CaresScreenModel{Category = "Mortgage Enquiries", Code = "DDS05", Title = "Direct debit enquiry"},
                new CaresScreenModel{Category = "Mortgage Applications", Code = "BMP13", Title = "Completed business"},
                new CaresScreenModel{Category = "Mortgage Applications", Code = "APP20", Title = "Applications submitted by branch"},
                new CaresScreenModel{Category = "Mortgage Applications", Code = "VET02", Title = "Vetting items summary"},
                new CaresScreenModel{Category = "Mortgage Applications", Code = "VET16", Title = "Application product code, amount and term"},
                new CaresScreenModel{Category = "Mortgage Applications", Code = "APP15", Title = "Applications credit score details"},
                new CaresScreenModel{Category = "Mortgage Applications", Code = "SOL02", Title = "Solicitors search by firm name"}
            });
        }
    }
}
