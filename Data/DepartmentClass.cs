using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPortal.Data
{
	[Table("tblDepartment", Schema = "public")]
	public class DepartmentClass
	{
		[Key]
		public int dept_id { get; set; }
		public string? dept_name { get; set; }
	}
}
