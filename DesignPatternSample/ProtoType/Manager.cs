using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.ProtoType
{
	public class Manager
	{
		private Hashtable hashTable = new Hashtable();
		public void Redister(string name, Prototype prototype)
		{
			hashTable.Add(name, prototype);
		}

		public Prototype Create(string name)
		{
			Prototype prototype = (Prototype)hashTable[name];
			return (Prototype)prototype.Clone();
		}
	}
}
