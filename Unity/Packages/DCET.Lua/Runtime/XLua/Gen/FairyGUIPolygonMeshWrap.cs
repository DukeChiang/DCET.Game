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
    public class FairyGUIPolygonMeshWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.PolygonMesh);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 4, 3);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPopulateMesh", _m_OnPopulateMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HitTest", _m_HitTest);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getpoints", _g_get_points);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getfillColor", _g_get_fillColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcolors", _g_get_colors);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getusePercentPositions", _g_get_usePercentPositions);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setfillColor", _s_set_fillColor);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setcolors", _s_set_colors);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setusePercentPositions", _s_set_usePercentPositions);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "points", _g_get_points);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fillColor", _g_get_fillColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colors", _g_get_colors);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "usePercentPositions", _g_get_usePercentPositions);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "fillColor", _s_set_fillColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "colors", _s_set_colors);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "usePercentPositions", _s_set_usePercentPositions);
            
			
			
			
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
					
					FairyGUI.PolygonMesh gen_ret = new FairyGUI.PolygonMesh();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.PolygonMesh constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPopulateMesh(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PolygonMesh gen_to_be_invoked = (FairyGUI.PolygonMesh)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.VertexBuffer _vb = (FairyGUI.VertexBuffer)translator.GetObject(L, 2, typeof(FairyGUI.VertexBuffer));
                    
                    gen_to_be_invoked.OnPopulateMesh( 
                        _vb );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HitTest(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.PolygonMesh gen_to_be_invoked = (FairyGUI.PolygonMesh)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Rect _contentRect;translator.Get(L, 2, out _contentRect);
                    UnityEngine.Vector2 _point;translator.Get(L, 3, out _point);
                    
                        bool gen_ret = gen_to_be_invoked.HitTest( 
                        _contentRect, 
                        _point );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_points(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PolygonMesh gen_to_be_invoked = (FairyGUI.PolygonMesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.points);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fillColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PolygonMesh gen_to_be_invoked = (FairyGUI.PolygonMesh)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.fillColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colors(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PolygonMesh gen_to_be_invoked = (FairyGUI.PolygonMesh)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.colors);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usePercentPositions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PolygonMesh gen_to_be_invoked = (FairyGUI.PolygonMesh)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.usePercentPositions);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fillColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PolygonMesh gen_to_be_invoked = (FairyGUI.PolygonMesh)translator.FastGetCSObj(L, 1);
                System.Nullable<UnityEngine.Color32> gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.fillColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colors(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PolygonMesh gen_to_be_invoked = (FairyGUI.PolygonMesh)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_usePercentPositions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.PolygonMesh gen_to_be_invoked = (FairyGUI.PolygonMesh)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.usePercentPositions = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
