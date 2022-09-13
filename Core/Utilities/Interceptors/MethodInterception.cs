using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{

    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation) //invocation: çalışmak istediğin method (add gibi)
        {
            // bütün metotların çatısı (bütün metotlar çalıştırılmadan önce buradan geçip oyle calışacak)
            var isSuccess = true;
            OnBefore(invocation);// methof un basında
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);//onexception: hata aldığında
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
