// <assemblyHash>3d361d3</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=11.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias gnd;
extern alias mqttf;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("GetNetData", false)]
[assembly: global::System.Reflection.AssemblyCompany("")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("GetNetData")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace GetNetData.Fakes
{
    /// <summary>GetNetData.StockDaTa 的填充码类型</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(gnd::GetNetData.StockDaTa))]
    [global::System.Diagnostics.DebuggerDisplay("StockDaTa \u7684\u586b\u5145\u7801")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimStockDaTa
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<gnd::GetNetData.StockDaTa>
    {
        /// <summary>初始化新的填充码实例</summary>
        public ShimStockDaTa()
        : base()
        {
        }

        /// <summary>初始化给定实例的新填充码</summary>
        public ShimStockDaTa(gnd::GetNetData.StockDaTa instance)
        : base(instance)
        {
        }

        /// <summary>为所有实例成员定义填充码</summary>
        public static partial class AllInstances
        {
            /// <summary>设置 StockDaTa.GetCount() 的 填充码</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<gnd::GetNetData.StockDaTa, int> GetCount
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("GetCount", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(gnd::GetNetData.StockDaTa), (object)null, "GetCount", typeof(int), new global::System.Type[]{});
                }
            }

            /// <summary>设置 StockDaTa.Get(String Url) 的 填充码</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<gnd::GetNetData.StockDaTa, string, string> GetString
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("Get", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(gnd::GetNetData.StockDaTa), (object)null, 
                         "Get", typeof(string), new global::System.Type[]{typeof(string)});
                }
            }

            /// <summary>设置 StockDaTa.SetUrl() 的 填充码</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<gnd::GetNetData.StockDaTa, string> SetUrl
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("SetUrl", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(gnd::GetNetData.StockDaTa), (object)null, "SetUrl", typeof(string), new global::System.Type[]{});
                }
            }

            /// <summary>设置 StockDaTa.SetUrl(String[] Resp) 的 填充码</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<gnd::GetNetData.StockDaTa, string[], string> SetUrlStringArray
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("SetUrl", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(gnd::GetNetData.StockDaTa), (object)null, 
                         "SetUrl", typeof(string), new global::System.Type[]{typeof(string).MakeArrayType()});
                }
            }

            /// <summary>设置 StockDaTa.SpiltStr(String input) 的 填充码</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<gnd::GetNetData.StockDaTa, string, string[]> SpiltStrString
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("SpiltStr", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(gnd::GetNetData.StockDaTa), (object)null, 
                         "SpiltStr", typeof(string).MakeArrayType(), new global::System.Type[]{typeof(string)});
                }
            }
        }

        /// <summary>为已填充的类型的所有方法分配“Current”行为</summary>
        public static void BehaveAsCurrent()
        {
            global::GetNetData.Fakes.ShimStockDaTa.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>为已填充的类型的所有方法分配“NotImplemented”行为</summary>
        public static void BehaveAsNotImplemented()
        {
            global::GetNetData.Fakes.ShimStockDaTa.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>为已填充的类型的所有方法分配行为</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(gnd::GetNetData.StockDaTa), value);
            }
        }

        /// <summary>设置 StockDaTa.StockDaTa() 的 填充码</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<gnd::GetNetData.StockDaTa> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(gnd::GetNetData.StockDaTa), (object)null, ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>设置 StockDaTa.GetCount() 的 填充码</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int> GetCount
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("GetCount", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<gnd::GetNetData.StockDaTa, int>(value)), 
                     typeof(gnd::GetNetData.StockDaTa), base.Instance, "GetCount", typeof(int), new global::System.Type[]{});
            }
        }

        /// <summary>设置 StockDaTa.Get(String Url) 的 填充码</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, string> GetString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("Get", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<gnd::GetNetData.StockDaTa, string, string>(value)), 
                                                                                                    typeof(gnd::GetNetData.StockDaTa), base.Instance, "Get", typeof(string), new global::System.Type[]{typeof(string)});
            }
        }

        /// <summary>设置 StockDaTa.SetUrl() 的 填充码</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string> SetUrl
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("SetUrl", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<gnd::GetNetData.StockDaTa, string>(value)), 
                                                                                                    typeof(gnd::GetNetData.StockDaTa), base.Instance, "SetUrl", typeof(string), new global::System.Type[]{});
            }
        }

        /// <summary>设置 StockDaTa.SetUrl(String[] Resp) 的 填充码</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string[], string> SetUrlStringArray
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("SetUrl", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<gnd::GetNetData.StockDaTa, string[], string>(value)), 
                                                                                                    typeof(gnd::GetNetData.StockDaTa), base.Instance, "SetUrl", typeof(string), new global::System.Type[]{typeof(string).MakeArrayType()});
            }
        }

        /// <summary>设置 StockDaTa.SpiltStr(String input) 的 填充码</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, string[]> SpiltStrString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("SpiltStr", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<gnd::GetNetData.StockDaTa, string, string[]>(value)), 
                                                                                                    typeof(gnd::GetNetData.StockDaTa), base.Instance, "SpiltStr", typeof(string).MakeArrayType(), new global::System.Type[]{typeof(string)});
            }
        }
    }
}
namespace GetNetData.Fakes
{
    /// <summary>GetNetData.StockDaTa 的存根类型</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(gnd::GetNetData.StockDaTa))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of StockDaTa")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubStockDaTa
      : gnd::GetNetData.StockDaTa
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<gnd::GetNetData.StockDaTa>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>初始化新实例</summary>
        public StubStockDaTa()
        {
            this.InitializeStub();
        }

        /// <summary>获取或设置一个值，该值指示是否应调用基方法而不调用回退行为</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>初始化 type StubStockDaTa 的新实例</summary>
        private void InitializeStub()
        {
        }

        /// <summary>获取或设置实例行为。</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>获取或设置实例观察者。</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
