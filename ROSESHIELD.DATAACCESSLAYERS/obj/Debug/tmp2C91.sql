CREATE TABLE [dbo].[Violencia] (
    [id] [int] NOT NULL IDENTITY,
    [descricao] [nvarchar](max),
    CONSTRAINT [PK_dbo.Violencia] PRIMARY KEY ([id])
)
CREATE TABLE [dbo].[EmpresaParceira] (
    [ID] [int] NOT NULL IDENTITY,
    [NomeVaga] [nvarchar](max),
    [AreaAtuacao] [nvarchar](max),
    [Cargo] [nvarchar](max),
    [Descricao] [nvarchar](max),
    [FaixaSalarial] [nvarchar](max),
    [HorarioTrabalho] [nvarchar](max),
    [DataCreate] [datetime] NOT NULL,
    [DataUpdate] [datetime] NOT NULL,
    [Nome] [nvarchar](max),
    [RG] [nvarchar](max),
    [OrgaoEmissor] [nvarchar](max),
    [CPF] [nvarchar](max),
    [CNPJ] [nvarchar](max),
    [Rua] [nvarchar](max),
    [Bairro] [nvarchar](max),
    [Numero] [nvarchar](max),
    [Estado] [nvarchar](max),
    [Cidade] [nvarchar](max),
    [Pais] [nvarchar](max),
    [Cep] [nvarchar](max),
    [TelefoneFixo] [nvarchar](max),
    [TelefoneCelular] [nvarchar](max),
    [Email] [nvarchar](max),
    [DatadeNascimento] [nvarchar](max),
    [Sexo] [nvarchar](max),
    [EstadoCivil] [nvarchar](max),
    [PortadorNecessidadesEspeciais] [nvarchar](max),
    [Escolaridade] [nvarchar](max),
    [Naturalidade] [nvarchar](max),
    [Nascionalidade] [nvarchar](max),
    [RazaoSocial] [nvarchar](max),
    [NomeFantasia] [nvarchar](max),
    [Links] [nvarchar](max),
    CONSTRAINT [PK_dbo.EmpresaParceira] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[Ong] (
    [ID] [int] NOT NULL IDENTITY,
    [perfil] [nvarchar](max),
    [DataCreate] [datetime] NOT NULL,
    [DataUpdate] [datetime] NOT NULL,
    [Nome] [nvarchar](max),
    [RG] [nvarchar](max),
    [OrgaoEmissor] [nvarchar](max),
    [CPF] [nvarchar](max),
    [CNPJ] [nvarchar](max),
    [Rua] [nvarchar](max),
    [Bairro] [nvarchar](max),
    [Numero] [nvarchar](max),
    [Estado] [nvarchar](max),
    [Cidade] [nvarchar](max),
    [Pais] [nvarchar](max),
    [Cep] [nvarchar](max),
    [TelefoneFixo] [nvarchar](max),
    [TelefoneCelular] [nvarchar](max),
    [Email] [nvarchar](max),
    [DatadeNascimento] [nvarchar](max),
    [Sexo] [nvarchar](max),
    [EstadoCivil] [nvarchar](max),
    [PortadorNecessidadesEspeciais] [nvarchar](max),
    [Escolaridade] [nvarchar](max),
    [Naturalidade] [nvarchar](max),
    [Nascionalidade] [nvarchar](max),
    [RazaoSocial] [nvarchar](max),
    [NomeFantasia] [nvarchar](max),
    [Links] [nvarchar](max),
    CONSTRAINT [PK_dbo.Ong] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[PoliciaMilitar] (
    [ID] [int] NOT NULL IDENTITY,
    [NomeDepartamento] [int] NOT NULL,
    [AbrangenciaDeAtuacao] [int] NOT NULL,
    [PontoFocalDeContato] [int] NOT NULL,
    [DataCreate] [datetime] NOT NULL,
    [DataUpdate] [datetime] NOT NULL,
    [Nome] [nvarchar](max),
    [RG] [nvarchar](max),
    [OrgaoEmissor] [nvarchar](max),
    [CPF] [nvarchar](max),
    [CNPJ] [nvarchar](max),
    [Rua] [nvarchar](max),
    [Bairro] [nvarchar](max),
    [Numero] [nvarchar](max),
    [Estado] [nvarchar](max),
    [Cidade] [nvarchar](max),
    [Pais] [nvarchar](max),
    [Cep] [nvarchar](max),
    [TelefoneFixo] [nvarchar](max),
    [TelefoneCelular] [nvarchar](max),
    [Email] [nvarchar](max),
    [DatadeNascimento] [nvarchar](max),
    [Sexo] [nvarchar](max),
    [EstadoCivil] [nvarchar](max),
    [PortadorNecessidadesEspeciais] [nvarchar](max),
    [Escolaridade] [nvarchar](max),
    [Naturalidade] [nvarchar](max),
    [Nascionalidade] [nvarchar](max),
    [RazaoSocial] [nvarchar](max),
    [NomeFantasia] [nvarchar](max),
    [Links] [nvarchar](max),
    CONSTRAINT [PK_dbo.PoliciaMilitar] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[ProfissionalDesconto] (
    [ID] [int] NOT NULL IDENTITY,
    [RamoAtuacao] [nvarchar](max),
    [DiaAtendimento] [nvarchar](max),
    [HorarioAtendimento] [nvarchar](max),
    [ValorCobrado] [nvarchar](max),
    [Desconto] [nvarchar](max),
    [DataCreate] [datetime] NOT NULL,
    [DataUpdate] [datetime] NOT NULL,
    [Nome] [nvarchar](max),
    [RG] [nvarchar](max),
    [OrgaoEmissor] [nvarchar](max),
    [CPF] [nvarchar](max),
    [CNPJ] [nvarchar](max),
    [Rua] [nvarchar](max),
    [Bairro] [nvarchar](max),
    [Numero] [nvarchar](max),
    [Estado] [nvarchar](max),
    [Cidade] [nvarchar](max),
    [Pais] [nvarchar](max),
    [Cep] [nvarchar](max),
    [TelefoneFixo] [nvarchar](max),
    [TelefoneCelular] [nvarchar](max),
    [Email] [nvarchar](max),
    [DatadeNascimento] [nvarchar](max),
    [Sexo] [nvarchar](max),
    [EstadoCivil] [nvarchar](max),
    [PortadorNecessidadesEspeciais] [nvarchar](max),
    [Escolaridade] [nvarchar](max),
    [Naturalidade] [nvarchar](max),
    [Nascionalidade] [nvarchar](max),
    [RazaoSocial] [nvarchar](max),
    [NomeFantasia] [nvarchar](max),
    [Links] [nvarchar](max),
    CONSTRAINT [PK_dbo.ProfissionalDesconto] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[ProfissionalVoluntario] (
    [ID] [int] NOT NULL IDENTITY,
    [RamoAtuacao] [nvarchar](max),
    [DiaAtendimento] [nvarchar](max),
    [HorarioAtendimento] [nvarchar](max),
    [DataCreate] [datetime] NOT NULL,
    [DataUpdate] [datetime] NOT NULL,
    [Nome] [nvarchar](max),
    [RG] [nvarchar](max),
    [OrgaoEmissor] [nvarchar](max),
    [CPF] [nvarchar](max),
    [CNPJ] [nvarchar](max),
    [Rua] [nvarchar](max),
    [Bairro] [nvarchar](max),
    [Numero] [nvarchar](max),
    [Estado] [nvarchar](max),
    [Cidade] [nvarchar](max),
    [Pais] [nvarchar](max),
    [Cep] [nvarchar](max),
    [TelefoneFixo] [nvarchar](max),
    [TelefoneCelular] [nvarchar](max),
    [Email] [nvarchar](max),
    [DatadeNascimento] [nvarchar](max),
    [Sexo] [nvarchar](max),
    [EstadoCivil] [nvarchar](max),
    [PortadorNecessidadesEspeciais] [nvarchar](max),
    [Escolaridade] [nvarchar](max),
    [Naturalidade] [nvarchar](max),
    [Nascionalidade] [nvarchar](max),
    [RazaoSocial] [nvarchar](max),
    [NomeFantasia] [nvarchar](max),
    [Links] [nvarchar](max),
    CONSTRAINT [PK_dbo.ProfissionalVoluntario] PRIMARY KEY ([ID])
)
ALTER TABLE [dbo].[Cadastro] ADD [DataOcorrencia] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [Filhos_Quantidade] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [Filhos_DataNascimento] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [Filhos_NomeEscola] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [Filhos_TelefoneEscola] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [Filhos_NecessidadeEspecial] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [UsoDeAlcool_Vitima] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [UsoDeDroga_Vitima] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [UsoDeAlcool_Agressor] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [UsoDeDroga_Agressor] [nvarchar](max)
ALTER TABLE [dbo].[Cadastro] ADD [TipodeViolência_id] [int]
CREATE INDEX [IX_TipodeViolência_id] ON [dbo].[Cadastro]([TipodeViolência_id])
ALTER TABLE [dbo].[Cadastro] ADD CONSTRAINT [FK_dbo.Cadastro_dbo.Violencia_TipodeViolência_id] FOREIGN KEY ([TipodeViolência_id]) REFERENCES [dbo].[Violencia] ([id])
DECLARE @var0 nvarchar(128)
SELECT @var0 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Cadastro')
AND col_name(parent_object_id, parent_column_id) = 'NomeCompleto';
IF @var0 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Cadastro] DROP CONSTRAINT [' + @var0 + ']')
ALTER TABLE [dbo].[Cadastro] DROP COLUMN [NomeCompleto]
DECLARE @var1 nvarchar(128)
SELECT @var1 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Cadastro')
AND col_name(parent_object_id, parent_column_id) = 'DataCadastro';
IF @var1 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Cadastro] DROP CONSTRAINT [' + @var1 + ']')
ALTER TABLE [dbo].[Cadastro] DROP COLUMN [DataCadastro]
DECLARE @var2 nvarchar(128)
SELECT @var2 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Cadastro')
AND col_name(parent_object_id, parent_column_id) = 'Filhos';
IF @var2 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Cadastro] DROP CONSTRAINT [' + @var2 + ']')
ALTER TABLE [dbo].[Cadastro] DROP COLUMN [Filhos]
DECLARE @var3 nvarchar(128)
SELECT @var3 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Cadastro')
AND col_name(parent_object_id, parent_column_id) = 'TipodeViolência';
IF @var3 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Cadastro] DROP CONSTRAINT [' + @var3 + ']')
ALTER TABLE [dbo].[Cadastro] DROP COLUMN [TipodeViolência]
DECLARE @var4 nvarchar(128)
SELECT @var4 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Cadastro')
AND col_name(parent_object_id, parent_column_id) = 'UsoDeAlcool_Drogas_Vitima';
IF @var4 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Cadastro] DROP CONSTRAINT [' + @var4 + ']')
ALTER TABLE [dbo].[Cadastro] DROP COLUMN [UsoDeAlcool_Drogas_Vitima]
DECLARE @var5 nvarchar(128)
SELECT @var5 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Cadastro')
AND col_name(parent_object_id, parent_column_id) = 'UsoDeAlcool_Drogas_Agressor';
IF @var5 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Cadastro] DROP CONSTRAINT [' + @var5 + ']')
ALTER TABLE [dbo].[Cadastro] DROP COLUMN [UsoDeAlcool_Drogas_Agressor]
DECLARE @var6 nvarchar(128)
SELECT @var6 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Cadastro')
AND col_name(parent_object_id, parent_column_id) = 'Situacao';
IF @var6 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Cadastro] DROP CONSTRAINT [' + @var6 + ']')
ALTER TABLE [dbo].[Cadastro] DROP COLUMN [Situacao]
DECLARE @var7 nvarchar(128)
SELECT @var7 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Cadastro')
AND col_name(parent_object_id, parent_column_id) = 'Motivododesligamento';
IF @var7 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Cadastro] DROP CONSTRAINT [' + @var7 + ']')
ALTER TABLE [dbo].[Cadastro] DROP COLUMN [Motivododesligamento]
DECLARE @var8 nvarchar(128)
SELECT @var8 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Cadastro')
AND col_name(parent_object_id, parent_column_id) = 'Desligamento';
IF @var8 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Cadastro] DROP CONSTRAINT [' + @var8 + ']')
ALTER TABLE [dbo].[Cadastro] DROP COLUMN [Desligamento]
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201910172312310_AutomaticMigration', N'ROSESHIELD.DATAACCESSLAYERS.Migrations.Configuration',  0x1F8B0800000000000400ED5DCB72E3B815DDA72AFFA0D22A99AA91DC3D9BA4CB9E29B524CF38693F62B95D9555174CC2326B48822129C7CE27A52A5F904516F341F985002445E245129040A6BBE7EE243C0E9E04CEB994EEFDEFBFFF73FAC34B144E9E719A05243E9BBE999D4C2738F6881FC4DBB3E92E7FFCF60FD31FBEFFED6F4ED77EF432B9DF97FB8E95A335E3EC6CFA94E7C9BBF93CF39E7084B259147829C9C8633EF34834473E99BF3D39F9E3FCCD9B39A610538A35999CDEEEE23C8870F1857E5D92D8C349BE43E125F1719855E9346753A04EAE5084B30479F86C7A7BBD596F7EBA587F58CD568BBBC562B95C6F361F167F5DDF6E66FE0345CAF14B3E9D2CC200D1CE6D70F8389DA0382639CA69D7DF7DCCF0264F49BCDD2434018577AF09A6E51E5198E16A48EF9AE2A6A33B79CB46376F2A1E343BD37ADCC59C4449885F58FF8AE19F4DCF83F089F06568A99B942438CD5FAB227FD9213AB13EF2E958584D3A01794A97723AB9442F1F70BCCD9FCEA6F4E374721EBC607F9F528DFE631CD095A795F27447BFCE3B9B5AA11C5DA1CCA3CB18E764F0E6AE4884D79947423478537738C48F241EABB92BECE12C2B166D9D25D8A39BD2719BA7736E33F1E96BBA59F2576E8B2D918F32FA7848BBECCFF85548E006718B1FABBA172B65A473B9A23C7656A71CEA459C7FF7763AB9DA85217A08713D2CEED1DDE424C53FE218A728C7FE0DCA739CD227F4C2C7C5304C36ECB547D2949E6FC108CBBA8B704AAA09A50FFAE00DBEBF1EBC89CB9BC19B280EB9AC6E861EDFB3F2DC53B74637D0C78CACF022F408093FDD07F4B6197EC98B265729D9A2515BAC06B9D8A6F41C21E998C31CADCDFB5FFE157BBB90D0836CB436D7B187A2207EA28FF0CD08CD5D3F64387D461EC1D92897F732C5F41CDD374553F01DBDCBAD9F3306F531F15D40B13B7EF0A1DFFE38FC4AA65B44D65130CA2E5DDE9C0FDFC6D5CD9F865F98DDF0E7E57B14A4E90864B5B8FB873FA0B27C0C62B11C4750DCA060F8836F8993D1F403051A7E71F68D2D71B80BD10897628402D7FA447FA9F8784479B9C123AC55F9BC2E83E71166903216D658CAA9CBAC9297233C66A5744EC73938AE50BE4B51385663744F9278ACE66ED13F10D990018C027AFA758EE21C6523C8E30F41FCF300FBF00A3D07DBC25C209F9341426BDD0724FCE59FA5FEBFC56151307B0A924A69EECD1F9FD4D2E729896E49C8D94894429F3664977A6C4F90BE927728DDE25CB6D234E6984E230DC3296D1807586902DFDE4AC3EA8C65A5A1C79497061E727D1A1BCFEE3A4AA8BE4437882E65901E34C79FBB258C3DE8F7683BFC43BEA0127391EF90FBE5D4303BFA480DDFCA6AA0EDA93184A1E0056D10BB454738FB7F22296D88DCA5E80115D63630408001020C1060800003041820C0000106083040749CB66080000344D186A9C8FC40B6417C90B43C40BE5F8C28DF3F663BA62346B8ABB3ECEF24F5FF5F0B784D1BFB0A2D03F4F3E348B72BA83F507FA0FE40FD81FA03F507EA0FD41FA83F507FBF12F57743C2804EE9651006393D33BF421DC1D6728513440F01E1006D6BB9E735E2438AE26DF1CA7B85A5F7898721DE10DAA973E2A17085D95F86D0B15D0445038A06140D281A5034A06840D180A20145038AE6D7A46852BCFFB1EBFE0DD057AA6AC67AC1B5C1F1D3F09B66B5EA9DBE9EEB1FC4138827104F209E403C817802F104E2A9E56902F104E209C45391AC114FE491B2B3621DD9FF8BD8BB89AF513EDDA2888CF56FB0558016398EFD910EECEAEF536336798F42922EC9C328BEA5EA6D09BF0C0429085210A420484190822005410A821404290852701029784FC21D1DF357FA2E0DC420C826904D9AC64036816C02D904B2096413C826904D209B403629B2694189189D412643F6D740ABE34EB1D3EBD89F187BF12C87C2FB05A523DA857990B0BF6FE5AF67D36F9459316960EFFC936BA071E929B570329BBD9127851BBE2A268B1FE40554955533D38444923BCA4A6F702ECDE074D2CCB9327A65B02206370A0584CBEB41911D70AA584A891EC4D2DB8A8A53A5F7D466AE3ED4BA456A4F4DE97F7E2A885CA00FAFF995AD0E4CFD0D6E3FA0E6CDB30E5957CC029B336574A3F305257C6ED7ABBB56E3B0972B7FD6E7DD5736A7D81C13F5B8F967687E08E2FE5CE010DB9F9AB9381F9A53B33E09EABCD379194EAD4A6061A1B471D74E2F5192D0039C8BC356A54C366510B6E5B71BFB0867518931F7B269C7B955B79493146DB194CB7E71EC53269E6639E3940F885D214B3F528AF59E7BFB76A4E34F5DB8FD76DD57609FABCBDC2414DDAC0DBA99D5733A50468B8B3163DD8652AA4E58683CE61C5663C25BD287288ADBCC805DB5E510593C929C678EAA46C2E271D55C736416F28AC762DFCD6BB368567C6DF65D5BBB8A9E2655E72355D9EC074D18BFEE7EF241FDF8FE961DF8C467EBBADFB5D8BC22D340CB456CE0F9807D1A683EDB06560ECEA781968B58F55A178C4FD77D5D39EDE6994BBBC7787BEA0298F13DD1E59B6F7E4DAC32055CCCB6C456A292B5F5BD297150EF3B1A900B98E36BC38DF1F8DA02E6F87268311E5ACE3347152288F1904286DD75B07FAB205F05FB743BB4FD8B05196D9F6E71A914EF16848BA4483147602F0EF8FAECBBC55C0BEF0484C91672CC110BC33F0F542458D42F8CFA0240916231233BE91428122CAEE3CA1A2F5CC9559A2D5DD09104AB27ACB2A50B4F56956631A79A6B77D971D7EA514A4B388F51A658F48399B9854EB004F3FAA2099B071273EC116B3BB50EB4CEB458B7D21E2D2C5B996477D288D666F9BC1173CD914BB3328F56A6D8EECBCA66AC6ECE2AC3626F75DB85854DD75DD4660CBC35581C049F63F1CC0B265FE1C917726C1045BBAE8829E6599C90BCF9563829F90CBB5BAC31D1CAB75993638E58D96179A82A49C5389D4B025416BF7345FD4A4608594D1B69ED96F8454EC4762BB681DAEEA8DB36DB2C32123FD56A74A5AEDA5CAC231E844BFE6CD6AC332A929395EB69C160FD7A1186319A34D194E4E7B74C354712C225F1604286056B28432209BCA14CB2B84BF57B74D5B547DBB0A4904682AC16B3CC3195C0453CAA9209DA07B40F681FC33905ED03DA07B40F681FD03EEE78B426F08B13F6ACC535E0CC2DF55A99B2A477D470345DB5EB9F2588967AED6F15BA709AE02FE2BDB24FFD6C565B8912E364AD35A8062BADAD358C224AAA28323CC23E0D1838307060E086730A0C1C1838307060E0C0C0DD71B2AEE01B4EE8597703064CAD0F603833B618B243DE1062AE85595B1BBE43B06F6B4BD81C439A701EE2E1A329005414A8285051C339052A0A5414A8285051A0A20EA928F77FAE0178684F4C86A2995E2E6A00321C1FD51A8C850C9B13AB08A8201E594592C579BA9286542458DC5E3A6E0A7C14F868DF8C001F053E0A7CB40319F828F051E0A372BE351FED7344EF8898F63763444D4D608621A782F74271BB71191607A3E4A1503816A53CEBDFC6B622EBF2CDD14507F43CAE9863310BB56F0961FC2D1E273A918020B7D606820C04190832106420C8409081201F4C90DBDC733BA7C8ED0D5992E42E20A0C943D164A0A2EDB5818A0215052A0A5414A8285051A0A27A2A2AFAF9D47BADD4B83F3DD44BA506CAD42B2573722A1FB97DCE4ED5E9D42E88EC674381D339DE60335B77E898BE56AE5E0DFB6A42993BBB4697C40F0AE7D617198BB852BBCAB69C01D947ACBABD1457B172917A735729F5F7DA556CE5A655F01F5BCC0CF3065BCC4856B98C95FDB69645A6133A0DCF81CF7CB66E5EB31C47335660B6F95BB80C03FA3835052E511C3CE22CBF233FE3F86CFAF6E4CDDBE9641106282B1DFCDA7BA4C57E34CF323FD4F8A3E58232E9F7FB1861980236FCDE404B0704F8E11DB9964DC5CF28F59E50FABB08BDFC9EC7348F8FC2FB707500CA9CB93A80615E5D1DC0689CADBA4395FDACBA43E6DDACBA43953DAC3AECAFCEAFAA03789DB35457B0A29B54C79D6DBC8BBAEDAE535CAD375407B8B22B540790822B5407786AE4356684C9DD445E3B188A8FBC76D4F09AE86AC7CDBA2682DA51805C94B4E370B84868C74DD4CECDB32F463473702BBB791085C864C7CDB8BBDB938F30765C9F9A286247E1E82285390194A2811DB7967CC4AFA3CF3E5D54AFA340F9C85D0EF6AC109DEBB8DD661281EBC81E7B4A94ADE34E004D24AD230175D1B28E3B38D58858C7755113F5EA284021B2D5714FB34EB3734AAF0BCD3884708B175333B9AA3322F4C9556910AEE52AE70DD57A098C27ADD375E817ABF41B1FA40E36AFE083D4C59D5B7A2275710D1DB143344254F444EA0051F1420AB2036407C80E901D203B407680EC00D9A1053C547618735E8DEB4F43A67B8048B8185624D4FF077772BCEFFD880E37F78A33CE2F566324955F4FE0B4C06981D302A7054E0B9C16382D705A2DE0E09CB6CB75E6174BB154DF9BDA770646587A4F9B87E3691D6B1E0E07141028205040A080400181020205040A780805ECF158F945D3409776CECAFBA58B936BB53A86F4016F04DE08BC117823F046E08DC01B81376A0147E08D7DEE24BF58E62878DB7171E248AE761C40EA7CEC3880153D51BA187AED8C125E78036B05D60AAC15582BB05660ADC05AB580A3B2D636FF8EC05BBF38DE0ACC10982130436086C00C811902330466D8CF0C39577FFBE3A7D5A3A3D8B175EC4F6E096BAD711D50F58B79D59B71A997BB300F12F613CBFCF56C7A329BBD5186D9A0D56EF378B02651C4FA4601A2CC14A78C38A2704962E6572E507D6BDEA401ED598242650452492DE5D53B8DAC31E59C154E28CB635ED6A5019AB465E8B1B26E4362E27DB321F87A541543EDE0B17EE52E396354F644E5ED53DA4BD349B3FB94152D1D3A527EF9C0D6BCDCC04DAEB24FC416B85DA634C1E5E9DAE0B27B1A91DD3CA84D2925740D2A857A9A2DFF69A73656A5EB9AA8B27A80D9DFC854D82255075A64F4404ABFA056D1E502BA86E4327D6DAA3FD9D1B4AB29A46D5B53AEB77DCDAB1F5D0F74C5F47DD095B4E80527E5BBFBC117ECEB095F56EA8BE828B6F7029970E5A563A0E7B669BB6F38F7C2AD8F73CBEDA2F34CAC5832C4016AEED3FA84ACF34EE7E5845609F4ABE2EA969ECB7446294D2DBFD1A50EB60D0473E41B634F3891EB3217F123D9DF12528FF64524C670892951A4C7F522CD8347E4E534BBA08CECA1BE47E1AE38981EB07F115FEFF26497D321E3E8217CE527835D305DED9FCE953E9F5E27EC5BE66208F705C5CBF175FC7E17847EDDEF73D5FAD006C16EAECAC4C4D63267A6A6ED6B8D7445658D1950357DF5857B87A324A460D975BC41CFB8BD6FFD7328CED8E92A40DB14455985D1D4A75FE9F6F3A397EFFF071053ADBA8A1D0100 , N'6.0.0-20911')

