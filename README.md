# [ET 4.0](https://github.com/egametang/ET/tree/Branch_V4.0) 
# [ET 论坛](https://bbs.honorworkroom.com/forum.php) 

__讨论QQ群 : 474643097__

# DCET 4.0的介绍：ET 4.0分支版本(双端行为树框架、FGUI框架版本)

2019.4.25 更新日志

-1.行为树增加共享变量，增加外部行为树设置，增加使用示例。
-2.优化FGUI框架。
-3.增加资源包管理插件AssetBundles-Browser-1.7.0。
-4.增加资源包分析标记工具 Tools/AssetBundles菜单下(包含资源零冗余分析标记)。
-5.优化ResourcesComponent保证Shader零冗余，并且防止Shader加载滞后和卸载再加载出现丢失(变紫)问题 。
-6.增加Clear工具，方便资源优化。
-7.增加引用加载器、预设光照贴图信息、相机深度贴图设置。

2019.2.14 更新日志

-1.增加双端行为树。
-2.增加FGUI框架及代码自动生成插件。
-3.UI框架分为Model层和Hotfix层，Model层不能热更一般只有一个下载资源页面，Hotfix层是全热更的。
-4.Unity/FairyGUI-Editor为UI编辑器软件目录；Unity/FGUIProject为本项目UI工程目录。

FGUI2ET插件 更新日志

-v1.0.5
-1.插件新增资源url自动生成代码功能。
-2.修改ETComponent.template模板，增加FUI.Name默认名为空时设为Id，方便查询。
-3.修改ETPackage.template模板，将FGUIPackage改成FUIPackage，增加资源url生成模板。

-v1.0.4
-1.为所有自定义组件缓存与GObject的映射，自动生成的代码会管理他们的Add和Remove，通过GObject.Get<T>()获取。
-2.配合FGUI的Pool机制，设计了自定义组件的GetFromPool()方法。使用GetFromPool()获取/创建，Dispose回收，在创建之后也可以使用GObject.Get<T>()获取，注意应该在GetPool 和 ToPool之间使用GetFromPool() 和 Dispose操作。

-v1.0.3
-1.修改自定义参数（FGUI2ET.GetMemberByTypeOrName），命名不准确：Key=FGUI2ET.GetMemberByIndexOrName，Value=Index或Name或No
-2.修复中文命名组件和包名的创建异常，但是不建议使用中文名，并且不允许使用中文属性名。
-3.所有的自定义组件全部继承自FUI，可以直接访问属性，挂在逻辑脚本。但是需要修改ET-FUI框架的FUI继承。如果不想改框架，可以自行修改ETComponent.template模板。暴露的参数基本可以满足自定义需求。

-v1.0.2
-1.删除无用的Binder代码。
-2.增加Package名代码，不用手动添加FGUIType.Package名类型。
-3.结合ET-FGUI框架，自动生成ET-FGUIComponent代码，遵循ET-Component的生命周期。
-4.增加组件名前缀自定义功能，在(文件>项目设置>自定义属性)中配置：
Key=FGUI2ET.ClassNamePrefix，Value=默认为空。
-5.生成组件中如果使用ETHotfix命名空间，可以在ETComponent.template中删除using ETHotfix;
-6.自定义组件本身不应该具有业务逻辑，所以自定义组件继承自Entity是为了在自定义组件上挂组件写逻辑，而不是直接在自定义组件的System中写逻辑，因为如果在自定义组件里写业务逻辑所有引用该组件的组件都会全部执行，不灵和。

-v1.0.1
-1.解决自定义GComponent嵌套类型生成无效。
-2.修复自定义组件代码逻辑错误，并在Unity中测试创建组件实例通过。
-3.增加命名空间前缀自定义功能，在(文件>项目设置>自定义属性)中配置：
Key=FGUI2ET.NameSpace，Value=默认为空。

-v1.0.0
-1.将plugins、template目录放在FGUI安装根目录覆盖即可。
-2.插件会自动生成默认参数，若需要修改，在(文件>项目设置>自定义属性)中配置：
Key=FGUI2ET，Value=Yes或No（开启关闭插件）
Key=FGUI2ET.Outpath，Value=ETHotfix代码生成路径
Key=FGUI2ET.GetMemberByTypeOrName，Value=Type或Name或No（按名字、类型生成组件成员或者不生成）。
-3.在项目设置中，当包设置勾选了FGUI自身的代码生成，即不会生成ETHotfix代码（一般主工程使用）。
