using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNETClassLib
{
    public class Class1
    {
			private int publicMember;

			public  Class1()
				{
			publicMember = 0;
				}

		public int PublicMember
		{
			get
			{
				return publicMember;
			}

			set
			{
				publicMember = value;
			}
		}
	}
}
