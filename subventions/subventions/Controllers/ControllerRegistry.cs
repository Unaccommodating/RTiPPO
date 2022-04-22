using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ControllerRegistry
{
	public List<Subvention> Records()
	{
		List<Subvention> subventions = new List<Subvention>();
		return subventions;
	}
	public List<Subvention> Records(int paramsSort, string paramsFilter)
    {
		List<Subvention> subventions = new List<Subvention>();
		return subventions;
	}
	public bool checkAccess(int id)
    {
		return true;
    }
	public Subvention OpenRecord(int id)
	{
		Subvention subventions = new Subvention();
		return subventions;
	}
	public ControllerRegistry(int id)
	{
		if (checkAccess(id))
			Records();
		else
			return;
	}
	public bool exportExcel(){
		return true;
	}
}

