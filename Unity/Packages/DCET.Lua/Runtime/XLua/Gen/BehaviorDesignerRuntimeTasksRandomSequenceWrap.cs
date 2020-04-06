﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class BehaviorDesignerRuntimeTasksRandomSequenceWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(BehaviorDesigner.Runtime.Tasks.RandomSequence);
			Utils.BeginObjectRegister(type, L, translator, 0, 12, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnAwake", _m_OnAwake);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStart", _m_OnStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CurrentChildIndex", _m_CurrentChildIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanExecute", _m_CanExecute);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnChildExecuted", _m_OnChildExecuted);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnConditionalAbort", _m_OnConditionalAbort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnEnd", _m_OnEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnReset", _m_OnReset);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getseed", _g_get_seed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getuseSeed", _g_get_useSeed);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setseed", _s_set_seed);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setuseSeed", _s_set_useSeed);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "seed", _g_get_seed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useSeed", _g_get_useSeed);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "seed", _s_set_seed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useSeed", _s_set_useSeed);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					BehaviorDesigner.Runtime.Tasks.RandomSequence gen_ret = new BehaviorDesigner.Runtime.Tasks.RandomSequence();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to BehaviorDesigner.Runtime.Tasks.RandomSequence constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnAwake(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnAwake(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStart(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnStart(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CurrentChildIndex(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.CurrentChildIndex(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanExecute(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.CanExecute(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnChildExecuted(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    BehaviorDesigner.Runtime.Tasks.TaskStatus _childStatus;translator.Get(L, 2, out _childStatus);
                    
                    gen_to_be_invoked.OnChildExecuted( 
                        _childStatus );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnConditionalAbort(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _childIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.OnConditionalAbort( 
                        _childIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnEnd(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnEnd(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnReset(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnReset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_seed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.seed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useSeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useSeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_seed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.seed = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useSeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                BehaviorDesigner.Runtime.Tasks.RandomSequence gen_to_be_invoked = (BehaviorDesigner.Runtime.Tasks.RandomSequence)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useSeed = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
