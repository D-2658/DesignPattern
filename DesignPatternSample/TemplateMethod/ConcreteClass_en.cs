using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.TemplateMethod
{
	public class ConcreteClass_en : AbstractClass
	{
		public override void Hello()
		{
			Console.WriteLine("Hello");
		}

		public override void World()
		{
			Console.WriteLine("World!");
		}
	}
}
