﻿delete from SysModule;
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('0','TopLevelMenu','Root','0','','',0,'',1,'Administrator','10/1/2012 12:00AM',0,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('BaseSample','Template Sample','Sample by Ajax','SampleFile','SysSample','',0,'',1,'Administrator',NULL,1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('Document','My Desktop','Start','PersonDocument','Home/Doc','',0,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('Info','My Profile','Info','PersonDocument','Home/Info','',0,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('InfoHome','Home','Home','Information','MIS/Article','',1,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('Information','Infomation Center','Information','OA','','',0,'',1,'Administrator','10/1/2012 12:00AM',0,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('ManageInfo','Management Center','Manage Article','Information','MIS/ManageArticle','',4,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('ModuleSetting','Module Mantaint','Module Setting','RightManage','SysModule','',100,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('MyInfo','My Information','My Article','Information','MIS/MyArticle','',2,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('PersonDocument','Personal Center','Person Center','0','','',2,'',1,'Administrator','10/1/2012 12:00AM',0,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('RightManage','Authorization Mangement','Authorities Management','0','','',4,'',1,'Administrator','10/1/2012 12:00AM',0,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('RoleAuthorize','Role Authorization','Role Authorize','RightManage','SysRight','',6,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('RoleManage','Role Mangement','Role Manage','RightManage','SysRole','',2,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SampleFile','Sample Files','SampleFile','0','SysSample','',1,'',1,'Administrator',NULL,0,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemConfig','System Configuration','System Config','SystemManage','SysConfig','',0,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemExcepiton','System Exceptions','System Exception','SystemManage','SysException','',2,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemJobs','Scheduled Tasks','System Jobs','TaskScheduling','Jobs/Jobs','',0,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemLog','Log','System Log','SystemManage','SysLog','',1,'',1,'Administrator','10/1/2012 12:00AM',1,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('SystemManage','System Management','System Management','0','','',3,'',1,'Administrator','10/1/2012 12:00AM',0,NULL)
INSERT INTO [SysModule] ([Id],[Name],[EnglishName],[ParentId],[Url],[Iconic],[Sort],[Remark],[State],[CreatePerson],[CreateTime],[IsLast],[Version]) values ('UserManage','Administrators','User Manage','RightManage','SysUser',NULL,1,NULL,1,'Administrator','10/1/2012 12:00AM',1,NULL)