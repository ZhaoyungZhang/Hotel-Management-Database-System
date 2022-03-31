# Hotel-Management-Database-System

[TOC]

## 开发框架

**语言** ：C#

**工具**：Visual Studio 2019, Microsoft SQL Server Management Studio 18

**数据库**：SQL Server 15.0.2

**OS**：Windows 10

---

## 源码地址

[Tcoder-l3est/Hotel-Management-Database-System: 数据库课设---酒店管理系统 (github.com)](https://github.com/Tcoder-l3est/Hotel-Management-Database-System)

## 数据库规划

### 任务目标

![image-20220331191200320](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331191200320.png)

![image-20220331203457738](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331203457738.png)

![image-20220331203516714](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331203516714.png)

### 权限

**管理员（经理）权限：**具有该系统的最高权限以及所有权限，可以对系统进行管理，可对数据库进行系统所提供的所有操作，特别地，负责员工和房间管理。权限具体陈述如下：

1、房间管理：包括房间各种属性的增加、查询、修改和删除。

2、员工信息管理：添加、查询、修改、删除所有员工的信息。

3、客户管理：包括客户信息的添加、查询、修改、删除等。

4、系统数据处理：数据查询，包括查看当前在馆书籍信息、当前所有违章罚款信息、所有被预约图书信息等。

5、预约入住操作：预约时需要输入客户身份证号和姓名以及手机号。如果该用户未预约，则选择合适房间并充值后可以预约，提示“预约成功”；如果该用户已经预约或者入住，则弹出窗口提示并禁止操作。

6、入住登记操作：入住时需要输入客户身份证号和姓名以及手机号。如果该用户未预约，则选择合适房间并充值后可以入住，提示“入住成功”；如果该用户已经预约，则必须按预约的房间来入住，否则提示并且禁止，并且检查是否超时，决定是否退还定金；如果该用户已入住，则禁止重复入住。

7、退房登记操作：退房时首先查看正在进行的业务订单。如果是正在入住的订单，则进行超时查询后进行下一步处理；如果未超时，则直接退房即可，相应的信息插入到历史订单并且入住订单中删除该订单；如果超时，则需要交纳额外的超时罚款之后，再退房。最后提示：“退房成功！”。

**员工权限：**使用系统的预约-入住-退房功能以及房间查询、客户管理。（无员工管理权限）具体权限如下：

1、房间查询：包括房间各种属性的查询。

2、客户管理：包括客户信息的添加、查询、修改、删除等。

3、系统数据处理：数据查询，包括查看当前在馆书籍信息、当前所有违章罚款信息、所有被预约图书信息等。

4、预约入住操作：预约时需要输入客户身份证号和姓名以及手机号。如果该用户未预约，则选择合适房间并充值后可以预约，提示“预约成功”；如果该用户已经预约或者入住，则弹出窗口提示并禁止操作。

5、入住登记操作：入住时需要输入客户身份证号和姓名以及手机号。如果该用户未预约，则选择合适房间并充值后可以入住，提示“入住成功”；如果该用户已经预约，则必须按预约的房间来入住，否则提示并且禁止，并且检查是否超时，决定是否退还定金；如果该用户已入住，则禁止重复入住。

6、退房登记操作：退房时首先查看正在进行的业务订单。如果是正在入住的订单，则进行超时查询后进行下一步处理；如果未超时，则直接退房即可，相应的信息插入到历史订单并且入住订单中删除该订单；如果超时，则需要交纳额外的超时罚款之后，再退房。最后提示：“退房成功！”。

## 数据库逻辑设计

### ER图

![image-20220331211657330](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331211657330.png)

### 索引

![image-20220331211816659](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331211816659.png)

在表“客户”中,对主键客户编号做了索引,作为该表的主索引。每次进行相应操作，都是根据客户编号来的，所以设置为主索引。并且客户编号是递增的。

其次在房间信息表中，对主键房间做了索引，作为该表的主索引。每次进行相应操作，都是根据房间号来查询房间的各种信息，所以设置为主索引。

## 应用程序设计

### 功能模块

​	该酒店管理系统共面对酒店内部两种角色使用：管理员（经理），员工（前台）。

​	管理员系统通过CS框架实现，具有预约入住，入住登记，退房登记，房间管理，员工管理，客户管理、订单管理七大功能；

​	员工系统通过CS框架实现，具有预约入住，入住登记，退房登记，房间查询，员工查询，客户管理、订单管理七大功能；

​	**系统通过检测输入的数据的位数、内容，检查是否符合数据库变量类型的要求，例如限制身份证号位数必须为18位，手机号必须是11位等，能够很好地保障数据库的统一。**

​	功能模块具体实现可见文档

---

#### 管理员功能

##### 房间管理

（1）在经理主界面，点击房间管理，即可进入房间管理主界面。

（2）点击房间查询母功能，选择查询子功能：全部房间，已入住房间，未入住房间，已预约房间，未预约房间，实现对房间状态的了解。

（3）点击类型查询母功能，选择查询子功能：普通房间，VIP房间，VVIP房间，大床房，双人间，有窗房间，无窗房间，实现对房间类型的查询。

（4）点击房间修改母功能，选择子功能：添加房间，修改房间，删除房间；

（4）添加房间：输入房间号，房间类型，价格，床型，窗型，系统默认添加时预约状态以及入住状态都是‘否’，实现房间的添加。系统会自动检查输入是否规范。

（5）修改房间：可以通过在查询时选中房间，输入更新后信息，来修改指定房间；也可以，直接输入房间号，房间类型，价格，床型，窗型，来修改房间信息。系统会自动检查输入是否规范。

（6）删除房间：选中房间后，点击删除房间，即可实现删除功能。

##### 员工管理

（1）点击员工管理功能按钮，进入员工管理界面；

（2）员工界面自动对经理（管理员）展示所有员工的全部信息，包括：员工号，员工姓名，员工性别，员工身份证号，员工职位，员工工资，员工登录密码，员工手机号。

（3）点击增加新员工按钮，进入添加员工界面，输入新员工全部信息，即可添加成功。如果增添的是员工职位是经理，则会自动记录在经理实体表中。系统会自动检查输入是否规范。

（4）点击修改员工信息按钮，进入修改员工信息子界面，并且默认修改的员工为原来界面选中的员工，输入新的员工信息，即修改成功。系统会自动检查输入是否规范。

（5）点击删除员工按钮，根据选中的员工，进行相应的删除

##### 客户管理

(1) 在主页面点击客户管理功能按钮，进入客户管理功能界面。

(2) 查看所有客户信息

(3) 点击增加新客户，进入增加客户子界面，输入客户的姓名，身份证，手机号，余额，类别后，点击增加按钮，即可增加成功。（系统自动实现客户编号的递增生成，自动设置客户的初始状态为‘未入住’，无需手动输入）

(4) 在客户管理界面选中某客户后，点击修改客户信息，即可进入修改客户子界面，显示当前修改的客户的编号，管理员输入对应修改的数值后，点击修改，即修改成功。（不可以从此界面修改客户状态，否则会引起数据的不一致）

(5) 在客户管理界面选中某客户后，点击删除客户按钮，确认删除后，即可删除成功。

(6) 客户充值功能：选中客户，点击客户充值，即可进入客户充值界面，系统自动锁定充值的客户，输入充值金额，点击充值，即可充值成功。(设置奖励机制，单次充值满一定金额可以升级客户类别，不同的客户类别享有不同的折扣，可以适应酒店的个性化营销策略)

(7) 修改折扣功能：配套于客户充值，点击进入修改客户类别折扣子功能界面，输入对应客户类别的折扣，便可修改客户享受的折扣力度。

(8) 客户管理界面，提供基于姓名、身份证号、客户的类别进行模糊查询，输相应的信息后点击对应按钮，即可查询。

(9) 刷新功能：点击刷新即可获得当前最新信息。

##### 订单管理

（1）在经理主界面点击订单管理，选择当前订单，即可进入当前订单管理界面。

（2）当前订单管理界面，点击查看订单，可以选择查看正在预约还未入住、正在入住还未退房的订单信息。

（3）订单修改功能：点击订单修改中的修改预约订单，即可进入订单修改界面，此界面可以修改预约的房间号、预约入住时间、以及入住天数，实现预约信息的修改。

（4）取消预约功能：在订单管理中选中订单，然后点击取消预约订单功能，系统自动检测是否是预约订单，如果不是，则无法取消，如果是，经过再次确认后，即可取消预约订单。并且一旦取消预约订单，则定金无法退还。

（5）刷新功能：点击刷新即可获得当前最新信息。

（6）若在经理主界面点击订单管理，选择历史订单，即可进入历史订单管理界面。

（7）历史订单界面，展示已经完成的订单，包括历史订单编号、客户编号、房间号、入住时间、退房时间、超时缴费、总消费，历史订单作为重要的酒店经营数据，只能查看，不能删改，也不能主动添加，只能在完成一个业务后由系统自动添加。

##### 预约入住

(1) 经理（管理员）主页面选择预约入住功能，即进入预约入住登录界面

(2) 输入客户的姓名，身份证号，手机号。系统根据身份证号检查客户是否第一次预约、入住本酒店，如果是，系统自动更新用户数据到数据库，增加新用户；然后检查是否已预约、入住，防止重复入住。并且对于可能出现变更的姓名和手机号，系统会自动更新。

(3) 输入信息后，点击下一步，进入预约入住-选择房间界面，该界面可以按类别查询空房间，包括普通房间、VIP、VVIP房间，并且还可以查看已预约、已入住房间。

(4) 该界面根据不同的用户信息，自动展示，当前客户编号，当前客户类别，当前客户预约状态，当前客户入住状态，以及享受的折扣。

(5) 输入预约房间号、预约日期、入住天数后，系统首先检查房间可入住，之后需缴纳总订单金额的10%作为定金，若后续按时入住，定金将退还，否则将额外扣除这部分费用。如果余额不够，则充值后继续入住。此外，系统会检索输入的房间号是否存在等各种规范数据的操作。

(6) 点击预约 系统更新数据库表的信息，若成功，则显示预约成功，否则预约失败。

(7) 客户充值功能：选中客户，点击客户充值，即可进入客户充值界面，系统自动锁定充值的客户，输入充值金额，点击充值，即可充值成功。(设置奖励机制，单次充值满一定金额可以升级客户类别，不同的客户类别享有不同的折扣，可以适应酒店的个性化营销策略)

##### 退房登记

（1）经理（管理员）主页面选择退房登记功能，即进入退房登记功能界面。

（2）退房登记主界面展示当前处于入住或者预约状态的订单，包括：当前订单号，客户编号，房间号，入住时间，预计退房时间，订单状态

（3）点击查看订单，还可以分类选择查看全部订单、入住订单、预约订单。

（4）在订单表中选中订单后，点击退房，系统首先检测是否是正在入住的订单（如果是预约订单则无法退房），之后系统自动检测，预约退房时间是否早于当前退房时间，如果是，则无需超时缴费，系统更新客户、订单、房间信息后。即退房成功；否则如果超时，则需缴纳超时缴费，超时缴费是根据超时天数以及房间价格相乘得到，没有折扣，以作为罚款，只有余额充足并且缴纳罚款后方可退房！此功能，便于酒店客房的个性化管理，非常实用！

(8) 客户充值功能：选中客户，点击客户充值，即可进入客户充值界面，系统自动锁定充值的客户，输入充值金额，点击充值，即可充值成功。(设置奖励机制，单次充值满一定金额可以升级客户类别，不同的客户类别享有不同的折扣，可以适应酒店的个性化营销策略)

（9）刷新功能：点击刷新即可获得当前最新信息。

---

#### 员工功能

##### 房间查询

（1）在员工主界面，点击房间查询按钮，即可进入房间查询功能主界面。

（2）点击房间查询母功能，选择查询子功能：全部房间，已入住房间，未入住房间，已预约房间，未预约房间，实现对房间状态的了解。

（3）点击类型查询母功能，选择查询子功能：普通房间，VIP房间，VVIP房间，大床房，双人间，有窗房间，无窗房间，实现对房间类型的查询。

（4）员工没有对房间进行增删改的权限，只能够查询。

##### 入住登记

（1）经理（管理员）主页面选择入住登记功能，即进入入住登记功能界面。

（2）入住登记界面先要由工作人员输入客户的姓名，身份证号以及手机号，根据身份证号，检查用户是否第一次入住，如果是系统自动更新用户数据库，增加新用户；并且检查，用户是否已经提前预约，用户现在是否在入住，以保证按预约入住和禁止重复入住。对于可能出现变更的姓名和手机号，系统会自动更新

（3）输入信息后，自动进入入住登记-选择房间界面，该界面可以按类别查询空房间，包括VIP房间，VVIP空房间，普通空房间，还可以查看已预约房间，已入住房间。

（4）该界面根据不同用户自动展示：当前客户编号，当前客户类别，当前客户预约状态，当前客户入住状态，以及享受的折扣。

（5）输入房间号，以及入住天数，系统自动检查用户是否按预约房间入住，如果不是，则无法入住；并且检查已入住用户，无法重复入住；此外，若是预约用户，系统自动检测，预约入住时间是否早于当前入住登记时间，如果是，则退还定金到客户余额，如果不是，则提示，预约超时不退还。

（6）符合入住条件的客户，系统会自动计算入住所需费用，以及客户余额，如果账户余额不足，则无法入住，需要及时充值。足够，在余额中扣除对应费用后，系统自动更新数据库表的信息成功后，即入住成功！

（7）客户充值功能：选中客户，点击客户充值，即可进入客户充值界面，系统自动锁定充值的客户，输入充值金额，点击充值，即可充值成功。(设置奖励机制，单次充值满一定金额可以升级客户类别，不同的客户类别享有不同的折扣，可以适应酒店的个性化营销策略)

##### 客户管理

（1）在主页面点击客户管理功能按钮，进入客户管理功能界面。

（2）查看所有客户信息

（3）点击增加新客户，进入增加客户子界面，输入客户的姓名，身份证，手机号，余额，类别后，点击增加按钮，即可增加成功。（系统自动实现客户编号的递增生成，自动设置客户的初始状态为‘未入住’，无需手动输入）

（4）在客户管理界面选中某客户后，点击修改客户信息，即可进入修改客户子界面，显示当前修改的客户的编号，管理员输入对应修改的数值后，点击修改，即修改成功。（不可以从此界面修改客户状态，否则会引起数据的不一致）

（5）在客户管理界面选中某客户后，点击删除客户按钮，确认删除后，即可删除成功。

客户充值功能：选中客户，点击客户充值，即可进入客户充值界面，系统自动锁定充值的客户，输入充值金额，点击充值，即可充值成功。(设置奖励机制，单次充值满一定金额可以升级客户类别，不同的客户类别享有不同的折扣，可以适应酒店的个性化营销策略)

（6）修改折扣功能：配套于客户充值，点击进入修改客户类别折扣子功能界面，输入对应客户类别的折扣，便可修改客户享受的折扣力度。

（7）客户管理界面，提供基于姓名、身份证号、客户的类别进行模糊查询，输相应的信息后点击对应按钮，即可查询。

（8）刷新功能：点击刷新即可获得当前最新信息。

##### 订单管理

（1）在经理主界面点击订单管理，选择当前订单，即可进入当前订单管理界面。

（2）当前订单管理界面，点击查看订单，可以选择查看正在预约还未入住、正在入住还未退房的订单信息。

（3）订单修改功能：点击订单修改中的修改预约订单，即可进入订单修改界面，此界面可以修改预约的房间号、预约入住时间、以及入住天数，实现预约信息的修改。

（4）取消预约功能：在订单管理中选中订单，然后点击取消预约订单功能，系统自动检测是否是预约订单，如果不是，则无法取消，如果是，经过再次确认后，即可取消预约订单。并且一旦取消预约订单，则定金无法退还。

（5）刷新功能：点击刷新即可获得当前最新信息。

（6）若在经理主界面点击订单管理，选择历史订单，即可进入历史订单管理界面。

（7）历史订单界面，展示已经完成的订单，包括历史订单编号、客户编号、房间号、入住时间、退房时间、超时缴费、总消费，历史订单作为重要的酒店经营数据，只能查看，不能删改，也不能主动添加，只能在完成一个业务后由系统自动添加。

##### 预约入住

（1）经理（管理员）主页面选择预约入住功能，即进入预约入住登录界面

（2）输入客户的姓名，身份证号，手机号。系统根据身份证号检查客户是否第一次预约、入住本酒店，如果是，系统自动更新用户数据到数据库，增加新用户；然后检查是否已预约、入住，防止重复入住。并且对于可能出现变更的姓名和手机号，系统会自动更新。

（3）输入信息后，点击下一步，进入预约入住-选择房间界面，该界面可以按类别查询空房间，包括普通房间、VIP、VVIP房间，并且还可以查看已预约、已入住房间。

（4）该界面根据不同的用户信息，自动展示，当前客户编号，当前客户类别，当前客户预约状态，当前客户入住状态，以及享受的折扣。

（5）输入预约房间号、预约日期、入住天数后，系统首先检查房间可入住，之后需缴纳总订单金额的10%作为定金，若后续按时入住，定金将退还，否则将额外扣除这部分费用。如果余额不够，则充值后继续入住。此外，系统会检索输入的房间号是否存在等各种规范数据的操作。

（6）点击预约 系统更新数据库表的信息，若成功，则显示预约成功，否则预约失败。

（7）客户充值功能：选中客户，点击客户充值，即可进入客户充值界面，系统自动锁定充值的客户，输入充值金额，点击充值，即可充值成功。(设置奖励机制，单次充值满一定金额可以升级客户类别，不同的客户类别享有不同的折扣，可以适应酒店的个性化营销策略)

 

##### 入住登记

（1）经理（管理员）主页面选择入住登记功能，即进入入住登记功能界面。

（2）入住登记界面先要由工作人员输入客户的姓名，身份证号以及手机号，根据身份证号，检查用户是否第一次入住，如果是系统自动更新用户数据库，增加新用户；并且检查，用户是否已经提前预约，用户现在是否在入住，以保证按预约入住和禁止重复入住。对于可能出现变更的姓名和手机号，系统会自动更新

（3）输入信息后，自动进入入住登记-选择房间界面，该界面可以按类别查询空房间，包括VIP房间，VVIP空房间，普通空房间，还可以查看已预约房间，已入住房间。

（4）该界面根据不同用户自动展示：当前客户编号，当前客户类别，当前客户预约状态，当前客户入住状态，以及享受的折扣。

（5）输入房间号，以及入住天数，系统自动检查用户是否按预约房间入住，如果不是，则无法入住；并且检查已入住用户，无法重复入住；此外，若是预约用户，系统自动检测，预约入住时间是否早于当前入住登记时间，如果是，则退还定金到客户余额，如果不是，则提示，预约超时不退还。

（6）符合入住条件的客户，系统会自动计算入住所需费用，以及客户余额，如果账户余额不足，则无法入住，需要及时充值。足够，在余额中扣除对应费用后，系统自动更新数据库表的信息成功后，即入住成功！

（7）客户充值功能：选中客户，点击客户充值，即可进入客户充值界面，系统自动锁定充值的客户，输入充值金额，点击充值，即可充值成功。(设置奖励机制，单次充值满一定金额可以升级客户类别，不同的客户类别享有不同的折扣，可以适应酒店的个性化营销策略)

##### 退房登记

（1）经理（管理员）主页面选择退房登记功能，即进入退房登记功能界面。

（2）退房登记主界面展示当前处于入住或者预约状态的订单，包括：当前订单号，客户编号，房间号，入住时间，预计退房时间，订单状态

（3）点击查看订单，还可以分类选择查看全部订单、入住订单、预约订单。

（4）在订单表中选中订单后，点击退房，系统首先检测是否是正在入住的订单（如果是预约订单则无法退房），之后系统自动检测，预约退房时间是否早于当前退房时间，如果是，则无需超时缴费，系统更新客户、订单、房间信息后。即退房成功；否则如果超时，则需缴纳超时缴费，超时缴费是根据超时天数以及房间价格相乘得到，没有折扣，以作为罚款，只有余额充足并且缴纳罚款后方可退房！此功能，便于酒店客房的个性化管理，非常实用！

（5）客户充值功能：选中客户，点击客户充值，即可进入客户充值界面，系统自动锁定充值的客户，输入充值金额，点击充值，即可充值成功。(设置奖励机制，单次充值满一定金额可以升级客户类别，不同的客户类别享有不同的折扣，可以适应酒店的个性化营销策略)

（6）刷新功能：点击刷新即可获得当前最新信息。

---

### 界面设计

#### 欢迎界面

 ![image-20220331212638580](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212638580.png)

#### 登陆界面

![image-20220331212657585](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212657585.png)

#### 经理主界面

![image-20220331212717449](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212717449.png)

#### 员工主界面

![image-20220331212748246](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212748246.png)

#### 预约入住

![image-20220331212819149](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212819149.png)

![image-20220331212836665](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212836665.png)

![image-20220331212850373](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212850373.png)

![image-20220331212900210](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212900210.png)

#### 充值界面

![image-20220331212919934](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212919934.png)

#### 入住登记

![image-20220331212941301](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331212941301.png)

#### 退房登记

![image-20220331213004850](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213004850.png)

#### 员工管理界面

![image-20220331213027065](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213027065.png)

##### 增删查改

![image-20220331213048211](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213048211.png)

![image-20220331213101850](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213101850.png)

#### 客户管理

![image-20220331213114878](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213114878.png)

![image-20220331213128633](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213128633.png)

#### 订单管理

![image-20220331213200353](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213200353.png)

![image-20220331213210722](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213210722.png)

#### 房间管理

![image-20220331213225087](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213225087.png)

![image-20220331213240506](https://gitee.com/zzy9/cloudimage/raw/master/img/image-20220331213240506.png)

### 事务设计

入住登记，输入信息后，会自动检索，之后在入住时，会同时对客户、房间、订单表做修改，需要保证ACID特性；通过采用从数据库直接读取某行数据以及从界面的表中读取数据，实现前期数据的处理；后期execute的sql必须要每一条都执行成功，写在一个sql中，从而保证了**原子性**。**多个表都修改**，保证了一致性。



## 参考文献

[1] Abraham Silberschatz,Henry F.Korth，《数据库系统概念》，机械工业出版社，2008。

[2] 王华杰，黄山 《精通C#数据库编程》，[科学出版社](http://search.dangdang.com/?key3=%BF%C6%D1%A7%B3%F6%B0%E6%C9%E7&medium=01&category_path=01.00.00.00.00.00)，2003

[3] Chirs H.Pappas,William H.Murray 《C#Windows编程》,人民邮电出版社，2002

[4] 刘勇，周学军，[《SQL Server 2000基础教程》](http://www.mendui.com/h_book/more206552.shtml)，人民邮电出版社，2007。
