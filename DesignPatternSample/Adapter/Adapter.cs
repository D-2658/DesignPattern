using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Adapter
{
	/// <summary>
	/// Adapter 既存の処理へ適合(Adapt)させるクラス
	/// 受け取ったインスタンスに処理を委譲している。
	/// 継承と委譲の二つの方法があるが委譲の方が優れているッぽい。
	/// 別インスタンスに処理を任せることを委譲というようです。
	/// </summary>
	public class Adapter:Target
	{
		Adaptee existingProcess;

		/// <summary>
		/// Adapteeのインスタンスを受け取る
		/// </summary>
		/// <param name="instance"></param>
		public Adapter(Adaptee instance)
		{
			this.existingProcess = instance;
		}

		/// <summary>
		/// TargetとAdapteeが似ている場合はリクエストを送るのみ
		/// </summary>
		public override void ExecuteComplicatedMethod()
		{
			this.existingProcess.ComplicatedMethod();
		}

		/// <summary>
		/// Targetでデータ構造等の変換が必要な場合
		/// </summary>
		/// <param name="msg"></param>
		public override void ExecuteShowMassage(string msg)
		{
			this.existingProcess.ComplicatedMethod_2(msg + "世界!");
		}
	}
}
