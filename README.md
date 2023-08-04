## Unity第一次作业

### 一、目标

* 熟悉Unity IDE的基本操作
* 熟悉Unity Hierarchy知识
* 掌握Unity脚本操作
  * 基本生命周期
  * 成员
  * 通过Prefab实例化GameObject

### 二、项目介绍

#### 1. 概览

本次作业（及之后作业）需要你用Unity实现一个棋盘塔防游戏。棋盘中有一条包含头（Start）尾（End）的路径，回合中敌人会从Start生成并匀速沿路径前进，直到到达End（游戏失败）。玩家通过在棋盘位置放置炮塔来对附近的敌人进行攻击。

#### 2. 关键对象与任务

##### Task0: Create GameObject

敌人的出生和结束需要出生点和死亡点。你需要实现：

* 通过IDE创建一个**START GameObject**作为出生点，一个**END GameObject**作为死亡点。为它们在棋盘上选择合适的位置。


##### Task1: Node

项目中需要操纵的GameObject是棋盘中的**方块Node**（位于Nodes父对象下），每个Node挂载了Node.cs脚本，控制nodes的行为。Node之上会放置**炮塔**对象（**turret GameObject**），炮塔运行时**从一个Prefab实例化**来构造。为了代码中访问到这个Prefab，我们将其设为Node脚本组件的成员（注意Node Component与Node GameObject的区别），并通过IDE Inspector**手动绑定**。据此，你需要实现关于Node的如下功能：

* 通过IDE Inspector手动绑定Prefab成员

* 通过访问Prefab成员，点击**空白Node**放置炮塔（turret）
* 点击**已有turret**的Node删除炮塔


##### Task2: WaveSpawner

全局的虚拟结点**Scripts GameObject**用于挂载全局性质的脚本，对游戏局面逻辑进行控制。本项目中该节点挂载了WaveSpawner.cs脚本，用于实现**敌人生成**的逻辑。为了简化，我们设置了一个傻瓜式的SpawnTrigger按钮（涉及UI事件，不需要知悉原理），希望每次点击它时刷出一波敌人。点击按钮时触发的功能绑定给WaveSpawner::SpawnControl方法来实现。

> 项目中的敌人GameObject是通过一个Prefab不断实例化产生的。为了确保在代码运行时访问到这个Prefab对象本身，我们设置了Wave GameObject（维护当前波的一些状态），通过访问它的属性可以获取敌人Prefab。

据此，你需要完成关于WaveSpawner的如下功能：

* 在IDE Inspector界面手动为WaveSpawner组件绑定其spawnPoint成员（是一个Transform组件），代表当前局面的初始位置。

* 实现SpawnControl方法，使得点击按钮之后在初始点实例化一个敌人。


##### Task3: Enemy

项目中会不断刷出**敌人Enemy GameObject**，每个实例会挂载Enemy.cs脚本控制其行为。本游戏中Enemy主要的行为是移动。据此，你需要完成关于Enemy的如下功能：

* 敌人自主地、随机地移动（不必沿着路径）

* （Optional）敌人自主地**沿着界面中的路径**WayPoint移动

> WayPoint是场景中一个GameObject，维护了路径所有拐点的位置，你可能需要在Enemy脚本内通过某种方式获取WayPoint对象并访问这些位置。


### 三、说明

你可以在`Assets/Scripts`目录下找到所有脚本。你可以在代码项目中搜索`TODO`，找到代码中需要你实现的部分。


**本次作业不需要**实现的功能：

* 精美的UI界面和操作

* 炮塔攻击

