using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Builder
{
	public class IDBuilder : Builder
	{
		private string id;
		private string name;
		private string age;

		public override void SetID(int id)
		{
			this.id = String.Format("国民番号：{0}", id);
		}

		public override void SetName(string name)
		{
			this.name = String.Format("名前：{0}", name);
		}

		public override void SetAge(int age)
		{
			this.age = String.Format("年齢：{0}", age);
		}

		public void GetResult()
		{
			Console.WriteLine($"{nameof(IDBuilder)}");
			Console.WriteLine($"{this.id:20}");
			Console.WriteLine($"{this.name:20}");
			Console.WriteLine($"{this.age:20}");
		}
	}
}
