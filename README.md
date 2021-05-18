### 需求分析
通过按键控制播放不同动画。

### 设计
两种方式，直接使用Animation和使用Animator控制器。

A:攻击。

R：按住，跑动。

I：Idle。

W：赢的动作。

### 脚本
SoliderController.cs:通过使用Animator控制，其中跑步设计为按住R键触发。

SoliderAnim：直接使用Animation控制，通过代码设置 动画转化。
