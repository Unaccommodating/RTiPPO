using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class Subvention
{
	public int id;
	private int destributor;
	private int recipient;
	private DateTime year;
	
	public int Id { get => id; set => id = value; }
	public int Destributor { get => destributor; set => destributor = value; }
	public int Recipient { get => recipient; set => recipient = value; }
	public DateTime Year { get => year; set => year = value; }
}
