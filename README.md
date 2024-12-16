# Remote Keyacrd[EXILED] 免手持卡 🤜✔📟

## **前言:**

### 你是否因为每次都要按Ctrl切到钥匙卡🎫而被打死？

### 你是否因为忘记切卡而抢不到Micro H.I.D.？👎

### 你是否因为忘记切卡而被SCP-106抓到口袋次元？👴

### **不用担心！ 不用担心！你可以用这个插件解决这些问题！🙌**</br></br>

## **介绍:**

### 免手持卡向服务器添加了不需要持卡就能对三种钥匙🔒解锁的功能！

### 你可以在配置文件中设置对免手持卡的配置！

```
//配置文件代码
[Description("启动免手持卡")]//为true时,启动该插件
public bool IsEnabled { get; set; } = true;

[Description("启动免手持卡-Debug")]//无效项
public bool Debug { get; set; } = false;

[Description("免手持卡对门有效")]//示例:为true时,你可以免手持卡交互电炮房门
public bool InteractingDoor { get; set; } = true;

[Description("免手持卡对物品柜有效")]//示例:为true时,你可以免手持卡交互SCP物品柜
public bool InteractingLocker { get; set; } = true;

[Description("免手持卡对发电机有效")]//示例:为true时,你可以免手持卡交互SCP-079的发电机
public bool InteractingGenerator { get; set; } = true;

[Description("免手持卡对核弹有效")]//示例:为true时,你可以免手持卡交互地表核弹盖
public bool InteractingWarhead { get; set; } = true;

[Description("拥有AmnesiaItems效果的玩家是否能免手持卡")]//示例:为false时,有AmnesiaItems效果的玩家无法免手持卡
public bool AmnesiaItems { get; set; } = false;
```

## **总结**

### 你不在需要切出钥匙卡就能交互这些烦人的门和柜子了！🎉

### 你再也不用怕了😭

### 别忘了，这个插件是EXILED框架的！💻
