--给SysModuleOperate插入操作码
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleCreate','Create','Create','BaseSample',0,0)
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleDelete','Delete','Delete','BaseSample',0,0)
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleDetails','Details','Details','BaseSample',0,0)
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleEdit','Edit','Edit','BaseSample',0,0)
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleExport','Export','Export','BaseSample',0,0)
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleQuery','Query','Query','BaseSample',0,0)
INSERT INTO [SysModuleOperate] ([Id],[Name],[KeyCode],[ModuleId],[IsValid],[Sort]) values ('BaseSampleSave','Save','Save','BaseSample',0,0)

--可以看出ModuleId对应是SysModule这个表的样例程序ID，IsValid是否要验证
--插入一个角色组到表SysRole

INSERT INTO [SysRole] ([Id],[Name],[Description],[CreateTime],[CreatePerson]) values ('administrator','Super Admin','All rights','2013/1/1','Administrator')
--将模块授权给SysRight

INSERT INTO [SysRight] ([Id],[ModuleId],[RoleId],[Rightflag]) values ('administratorSampleFile','SampleFile','administrator',1)
INSERT INTO [SysRight] ([Id],[ModuleId],[RoleId],[Rightflag]) values ('administratorBaseSample','BaseSample','administrator',1)
--把权限赋给角色SysRightOperate


INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleCreate','administratorBaseSample','Create',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleDelete','administratorBaseSample','Delete',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleDetails','administratorBaseSample','Details',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleEdit','administratorBaseSample','Edit',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleExport','administratorBaseSample','Export',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleQuery','administratorBaseSample','Query',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleSave','administratorBaseSample','Save',1)

--把操作码赋给角色的权限，比如附了Create这个操作码，那么角色拥有创建的权限
--创建一个用户吧 SysUser

INSERT INTO [SysUser] ([Id],[UserName],[Password],[TrueName],[Card],[MobileNumber],[PhoneNumber],[QQ],[EmailAddress],[OtherContact],[Province],[City],[Village],[Address],[State],[CreateTime],[CreatePerson],[Sex],[Birthday],[JoinDate],[Marital],[Political],[Nationality],[Native],[School],[Professional],[Degree],[DepId],[PosId],[Expertise],[JobState],[Photo],[Attach]) 
values ('admin','admin','01-92-02-3A-7B-BD-73-25-05-16-F0-69-DF-18-B5-00','System Admin',NULL,NULL,'06638888888','324345345','ymnets@sina.com','MSN：ymnets','440000','440100','440101','Little Village',1,'11 18 2012  3:40PM','admin','Male','1985/1/1','2013/1/1','UnMarried','China','China','Guangdong JieYang City','US Haford','Computing Science','Baclor','20000','20001','Good and friendly','On Duty',NULL,NULL)

--这里有个加密的01-92-02-3A-7B-BD-73-25-05-16-F0-69-DF-18-B5-00密码，讲到用户的时候会有加密这个类

--把角色分配给用户 SysRoleSysUser

INSERT INTO [SysRoleSysUser] ([SysUserId],[SysRoleId]) values ('admin','administrator')