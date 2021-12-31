using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.ProtoType
{
	public abstract class Prototype : ICloneable
	{
		abstract public void GetStatus();
		public abstract object Clone();
	}
}
