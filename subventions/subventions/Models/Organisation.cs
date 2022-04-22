using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Organisation
{
	private int id;
	private string name;
	private string legal_adress;
	private int distr_id;
	private int org_type;
	
	public int Id { get => id; set => id = value; }
	public string Name { get => name; set => name = value; }
	public string Legal_adress { get => legal_adress; set => legal_adress = value; }
	public int Distr_id { get => distr_id; set => distr_id = value; }
	public int Org_type { get => org_type; set => org_type = value; }
}