using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.ProtoType
{
	public class ConcretePrototyoe:Prototype
	{
		public int Status = 0;

		public override void GetStatus()
		{
			Console.WriteLine("状態は{0}です。", Status);
		}

		public override object Clone()
		{
			return MemberwiseClone();
		}
	}
}
