namespace GSX_Studio
{
	public partial class WaitForm1 : global::DevExpress.XtraWaitForm.WaitForm
	{
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				try
				{
					this.CleanupManaged();
					return;
				}
				finally
				{
					base.Dispose(true);
				}
			}
			base.Dispose(false);
		}
	}
}
