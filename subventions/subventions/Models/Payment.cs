using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class Payment
{
	private int id;
	private int subvention;
	private int amount;
	private DateTime pay_date;
	
	public int Id { get => id; set => id = value; }
	public int Subvention { get => subvention; set => subvention = value; }
	public int Amount { get => amount; set => amount = value; }
	public DateTime Pay_date { get => pay_date; set => pay_date = value; }
}
