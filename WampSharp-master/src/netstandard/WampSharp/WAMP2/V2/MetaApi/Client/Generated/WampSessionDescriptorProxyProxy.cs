using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using WampSharp.V2;
using WampSharp.V2.CalleeProxy;
using WampSharp.V2.Client;

namespace WampSharp.V2.MetaApi
{
    //------------------------------------------------------------------------------
    // <auto-generated>
    //     This code was generated by a tool.
    //
    //     Changes to this file may cause incorrect behavior and will be lost if
    //     the code is regenerated.
    // </auto-generated>
    //------------------------------------------------------------------------------
    internal class WampSessionDescriptorProxyProxy : CalleeProxyBase, global::WampSharp.V2.MetaApi.IWampSessionDescriptorProxy
    {
        private static readonly InvokeAsyncDelegate<long> mMethodHandler0 = GetInvokeAsync<long>(
            GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSessionDescriptorProxy instance) => instance.CountSessionsAsync())
        );
        private static readonly InvokeAsyncDelegate<long[]> mMethodHandler1 = GetInvokeAsync<long[]>(
            GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSessionDescriptorProxy instance) => instance.GetAllSessionIdsAsync())
        );
        private static readonly InvokeAsyncDelegate<global::WampSharp.V2.MetaApi.WampSessionDetails> mMethodHandler2 = GetInvokeAsync<global::WampSharp.V2.MetaApi.WampSessionDetails>(
            GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSessionDescriptorProxy instance) => instance.GetSessionDetailsAsync(default(long)))
        );
        private static readonly InvokeSyncDelegate<long> mMethodHandler3 = GetInvokeSync<long>(
            GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSessionDescriptor instance) => instance.CountSessions())
        );
        private static readonly InvokeSyncDelegate<long[]> mMethodHandler4 = GetInvokeSync<long[]>(
            GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSessionDescriptor instance) => instance.GetAllSessionIds())
        );
        private static readonly InvokeSyncDelegate<global::WampSharp.V2.MetaApi.WampSessionDetails> mMethodHandler5 = GetInvokeSync<global::WampSharp.V2.MetaApi.WampSessionDetails>(
            GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSessionDescriptor instance) => instance.GetSessionDetails(default(long)))
        );

        public WampSessionDescriptorProxyProxy
                (IWampRealmProxy realmProxy,
                 ICalleeProxyInterceptor interceptor)
            : base(realmProxy, interceptor)
        {
        }
        
        public Task<long> CountSessionsAsync()
        {
            return mMethodHandler0(this, global::System.Threading.CancellationToken.None);
        }
        
        public Task<long[]> GetAllSessionIdsAsync()
        {
            return mMethodHandler1(this, global::System.Threading.CancellationToken.None);
        }
        
        public Task<global::WampSharp.V2.MetaApi.WampSessionDetails> GetSessionDetailsAsync(long sessionId)
        {
            return mMethodHandler2(this, global::System.Threading.CancellationToken.None, sessionId);
        }
        
        public long CountSessions()
        {
            return mMethodHandler3(this);
        }
        
        public long[] GetAllSessionIds()
        {
            return mMethodHandler4(this);
        }
        
        public global::WampSharp.V2.MetaApi.WampSessionDetails GetSessionDetails(long sessionId)
        {
            return mMethodHandler5(this, sessionId);
        }
    }
}