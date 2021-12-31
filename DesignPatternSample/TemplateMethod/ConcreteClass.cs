using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.TemplateMethod
{
	public class ConcreteClass : AbstractClass
	{
		public override void Hello()
		{
			Console.WriteLine("こんにちは");
		}

		public override void World()
		{
			Console.WriteLine("世界!");
		}
	}
}
