using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Adapter
{
	/// <summary>
	/// Target Adapteeを動かすうえで必要なメソッドを定義するクラス。
	/// </summary>
	public abstract class Target
	{
		/// <summary>
		/// クライアントが使いたいメソッドその1
		/// </summary>
		public abstract void ExecuteComplicatedMethod();

		/// <summary>
		/// クライアントが使いたいメソッドその2
		/// </summary>
		/// <param name="msg"></param>
		public abstract void ExecuteShowMassage(string msg);
	}
}
