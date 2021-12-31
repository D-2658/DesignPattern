using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Builder
{
	/// <summary>
	/// 広告
	/// </summary>
	public abstract class Builder
	{
		public abstract void SetID(int id);
		public abstract void SetName(string name);
		public abstract void SetAge(int age);
	}
}
