using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ControllerAddOrEdit
{
    string message = "";

    public string addRecord(Subvention record)
    {
        return message;
    }

    public string editRecord(Subvention record)
    {
        return message;
    }

    public string addPayment(Payment payment)
    {
        return message;
    }

    public string editPayment(Payment payment)
    {
        return message;
    }

    public List<Subvention> getRecord(int id)
    {
        List<Subvention> subventions = new List<Subvention>();
        return subventions;
    }

    public List<Payment> getPayment(int id)
    {
        List<Payment> payments = new List<Payment>();
        return payments;
    }
}