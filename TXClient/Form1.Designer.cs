namespace TXClient
{
    partial class MainForms
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForms));
            this.Tim_Time = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog_prikey = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_location = new System.Windows.Forms.Label();
            this.btn_location_ico = new System.Windows.Forms.Button();
            this.imglist_location = new System.Windows.Forms.ImageList(this.components);
            this.Btn_ToSub = new System.Windows.Forms.Button();
            this.btn_imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ControlsBox = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_ToAdd = new System.Windows.Forms.Button();
            this.Btn_Send_String = new System.Windows.Forms.Button();
            this.imglst_btn_send = new System.Windows.Forms.ImageList(this.components);
            this.Num3_group = new System.Windows.Forms.GroupBox();
            this.RTxt_FEE = new System.Windows.Forms.RichTextBox();
            this.RTxt_TotalFasd = new System.Windows.Forms.RichTextBox();
            this.Num1_group = new System.Windows.Forms.GroupBox();
            this.RTxt_Balance = new System.Windows.Forms.RichTextBox();
            this.com_from = new System.Windows.Forms.ComboBox();
            this.Num2_group = new System.Windows.Forms.GroupBox();
            this.radio_Private = new System.Windows.Forms.RadioButton();
            this.radio_Public = new System.Windows.Forms.RadioButton();
            this.Btn_Send_Byte = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btx_exit = new System.Windows.Forms.Button();
            this.imglst_util = new System.Windows.Forms.ImageList(this.components);
            this.btn__ = new System.Windows.Forms.Button();
            this.btn_FormExtend = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox2.SuspendLayout();
            this.Num3_group.SuspendLayout();
            this.Num1_group.SuspendLayout();
            this.Num2_group.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tim_Time
            // 
            this.Tim_Time.Enabled = true;
            this.Tim_Time.Interval = 1024;
            this.Tim_Time.Tick += new System.EventHandler(this.Tim_Time_Tick);
            // 
            // openFileDialog_prikey
            // 
            this.openFileDialog_prikey.FileName = "openFileDialog_prikey";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.lbl_location);
            this.groupBox2.Controls.Add(this.btn_location_ico);
            this.groupBox2.Controls.Add(this.Btn_ToSub);
            this.groupBox2.Controls.Add(this.ControlsBox);
            this.groupBox2.Controls.Add(this.Btn_ToAdd);
            this.groupBox2.Controls.Add(this.Btn_Send_String);
            this.groupBox2.Controls.Add(this.Num3_group);
            this.groupBox2.Controls.Add(this.Num1_group);
            this.groupBox2.Controls.Add(this.Num2_group);
            this.groupBox2.Controls.Add(this.Btn_Send_Byte);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 0.1F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(8, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 376);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // lbl_location
            // 
            this.lbl_location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("돋움", 9F);
            this.lbl_location.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_location.Location = new System.Drawing.Point(674, 5);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(65, 12);
            this.lbl_location.TabIndex = 26;
            this.lbl_location.Text = "Location : ";
            // 
            // btn_location_ico
            // 
            this.btn_location_ico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_location_ico.ImageKey = "A1.gif";
            this.btn_location_ico.ImageList = this.imglist_location;
            this.btn_location_ico.Location = new System.Drawing.Point(674, 3);
            this.btn_location_ico.Name = "btn_location_ico";
            this.btn_location_ico.Size = new System.Drawing.Size(21, 15);
            this.btn_location_ico.TabIndex = 25;
            this.btn_location_ico.UseVisualStyleBackColor = true;
            // 
            // imglist_location
            // 
            this.imglist_location.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist_location.ImageStream")));
            this.imglist_location.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist_location.Images.SetKeyName(0, "A1.gif");
            this.imglist_location.Images.SetKeyName(1, "A2.gif");
            this.imglist_location.Images.SetKeyName(2, "AD.gif");
            this.imglist_location.Images.SetKeyName(3, "AE.gif");
            this.imglist_location.Images.SetKeyName(4, "AF.gif");
            this.imglist_location.Images.SetKeyName(5, "AG.gif");
            this.imglist_location.Images.SetKeyName(6, "AI.gif");
            this.imglist_location.Images.SetKeyName(7, "AL.gif");
            this.imglist_location.Images.SetKeyName(8, "AM.gif");
            this.imglist_location.Images.SetKeyName(9, "AN.gif");
            this.imglist_location.Images.SetKeyName(10, "AO.gif");
            this.imglist_location.Images.SetKeyName(11, "AP.gif");
            this.imglist_location.Images.SetKeyName(12, "AQ.gif");
            this.imglist_location.Images.SetKeyName(13, "AR.gif");
            this.imglist_location.Images.SetKeyName(14, "AS.gif");
            this.imglist_location.Images.SetKeyName(15, "AT.gif");
            this.imglist_location.Images.SetKeyName(16, "AU.gif");
            this.imglist_location.Images.SetKeyName(17, "AW.gif");
            this.imglist_location.Images.SetKeyName(18, "AZ.gif");
            this.imglist_location.Images.SetKeyName(19, "BA.gif");
            this.imglist_location.Images.SetKeyName(20, "BB.gif");
            this.imglist_location.Images.SetKeyName(21, "BD.gif");
            this.imglist_location.Images.SetKeyName(22, "BE.gif");
            this.imglist_location.Images.SetKeyName(23, "BF.gif");
            this.imglist_location.Images.SetKeyName(24, "BG.gif");
            this.imglist_location.Images.SetKeyName(25, "BH.gif");
            this.imglist_location.Images.SetKeyName(26, "BI.gif");
            this.imglist_location.Images.SetKeyName(27, "BJ.gif");
            this.imglist_location.Images.SetKeyName(28, "BM.gif");
            this.imglist_location.Images.SetKeyName(29, "BN.gif");
            this.imglist_location.Images.SetKeyName(30, "BO.gif");
            this.imglist_location.Images.SetKeyName(31, "BR.gif");
            this.imglist_location.Images.SetKeyName(32, "BS.gif");
            this.imglist_location.Images.SetKeyName(33, "BT.gif");
            this.imglist_location.Images.SetKeyName(34, "BV.gif");
            this.imglist_location.Images.SetKeyName(35, "BW.gif");
            this.imglist_location.Images.SetKeyName(36, "BY.gif");
            this.imglist_location.Images.SetKeyName(37, "BZ.gif");
            this.imglist_location.Images.SetKeyName(38, "CA.gif");
            this.imglist_location.Images.SetKeyName(39, "CD.gif");
            this.imglist_location.Images.SetKeyName(40, "CF.gif");
            this.imglist_location.Images.SetKeyName(41, "CG.gif");
            this.imglist_location.Images.SetKeyName(42, "CH.gif");
            this.imglist_location.Images.SetKeyName(43, "CI.gif");
            this.imglist_location.Images.SetKeyName(44, "CK.gif");
            this.imglist_location.Images.SetKeyName(45, "CL.gif");
            this.imglist_location.Images.SetKeyName(46, "CM.gif");
            this.imglist_location.Images.SetKeyName(47, "CN.gif");
            this.imglist_location.Images.SetKeyName(48, "CO.gif");
            this.imglist_location.Images.SetKeyName(49, "CR.gif");
            this.imglist_location.Images.SetKeyName(50, "CS.gif");
            this.imglist_location.Images.SetKeyName(51, "CU.gif");
            this.imglist_location.Images.SetKeyName(52, "CV.gif");
            this.imglist_location.Images.SetKeyName(53, "CY.gif");
            this.imglist_location.Images.SetKeyName(54, "CZ.gif");
            this.imglist_location.Images.SetKeyName(55, "DE.gif");
            this.imglist_location.Images.SetKeyName(56, "DJ.gif");
            this.imglist_location.Images.SetKeyName(57, "DK.gif");
            this.imglist_location.Images.SetKeyName(58, "DM.gif");
            this.imglist_location.Images.SetKeyName(59, "DO.gif");
            this.imglist_location.Images.SetKeyName(60, "DZ.gif");
            this.imglist_location.Images.SetKeyName(61, "EC.gif");
            this.imglist_location.Images.SetKeyName(62, "EE.gif");
            this.imglist_location.Images.SetKeyName(63, "EG.gif");
            this.imglist_location.Images.SetKeyName(64, "ER.gif");
            this.imglist_location.Images.SetKeyName(65, "ES.gif");
            this.imglist_location.Images.SetKeyName(66, "ET.gif");
            this.imglist_location.Images.SetKeyName(67, "EU.gif");
            this.imglist_location.Images.SetKeyName(68, "FI.gif");
            this.imglist_location.Images.SetKeyName(69, "FJ.gif");
            this.imglist_location.Images.SetKeyName(70, "FK.gif");
            this.imglist_location.Images.SetKeyName(71, "FM.gif");
            this.imglist_location.Images.SetKeyName(72, "FO.gif");
            this.imglist_location.Images.SetKeyName(73, "FR.gif");
            this.imglist_location.Images.SetKeyName(74, "GA.gif");
            this.imglist_location.Images.SetKeyName(75, "GB.gif");
            this.imglist_location.Images.SetKeyName(76, "GD.gif");
            this.imglist_location.Images.SetKeyName(77, "GE.gif");
            this.imglist_location.Images.SetKeyName(78, "GF.gif");
            this.imglist_location.Images.SetKeyName(79, "GH.gif");
            this.imglist_location.Images.SetKeyName(80, "GI.gif");
            this.imglist_location.Images.SetKeyName(81, "GL.gif");
            this.imglist_location.Images.SetKeyName(82, "GM.gif");
            this.imglist_location.Images.SetKeyName(83, "GN.gif");
            this.imglist_location.Images.SetKeyName(84, "GP.gif");
            this.imglist_location.Images.SetKeyName(85, "GQ.gif");
            this.imglist_location.Images.SetKeyName(86, "GR.gif");
            this.imglist_location.Images.SetKeyName(87, "GT.gif");
            this.imglist_location.Images.SetKeyName(88, "GU.gif");
            this.imglist_location.Images.SetKeyName(89, "GW.gif");
            this.imglist_location.Images.SetKeyName(90, "GY.gif");
            this.imglist_location.Images.SetKeyName(91, "HK.gif");
            this.imglist_location.Images.SetKeyName(92, "HM.gif");
            this.imglist_location.Images.SetKeyName(93, "HN.gif");
            this.imglist_location.Images.SetKeyName(94, "HR.gif");
            this.imglist_location.Images.SetKeyName(95, "HT.gif");
            this.imglist_location.Images.SetKeyName(96, "HU.gif");
            this.imglist_location.Images.SetKeyName(97, "ID.gif");
            this.imglist_location.Images.SetKeyName(98, "IE.gif");
            this.imglist_location.Images.SetKeyName(99, "IL.gif");
            this.imglist_location.Images.SetKeyName(100, "IN.gif");
            this.imglist_location.Images.SetKeyName(101, "IO.gif");
            this.imglist_location.Images.SetKeyName(102, "IQ.gif");
            this.imglist_location.Images.SetKeyName(103, "IR.gif");
            this.imglist_location.Images.SetKeyName(104, "IS.gif");
            this.imglist_location.Images.SetKeyName(105, "IT.gif");
            this.imglist_location.Images.SetKeyName(106, "JM.gif");
            this.imglist_location.Images.SetKeyName(107, "JO.gif");
            this.imglist_location.Images.SetKeyName(108, "JP.gif");
            this.imglist_location.Images.SetKeyName(109, "KE.gif");
            this.imglist_location.Images.SetKeyName(110, "KG.gif");
            this.imglist_location.Images.SetKeyName(111, "KH.gif");
            this.imglist_location.Images.SetKeyName(112, "KI.gif");
            this.imglist_location.Images.SetKeyName(113, "KM.gif");
            this.imglist_location.Images.SetKeyName(114, "KN.gif");
            this.imglist_location.Images.SetKeyName(115, "KP.gif");
            this.imglist_location.Images.SetKeyName(116, "KR.gif");
            this.imglist_location.Images.SetKeyName(117, "KW.gif");
            this.imglist_location.Images.SetKeyName(118, "KY.gif");
            this.imglist_location.Images.SetKeyName(119, "KZ.gif");
            this.imglist_location.Images.SetKeyName(120, "LA.gif");
            this.imglist_location.Images.SetKeyName(121, "LB.gif");
            this.imglist_location.Images.SetKeyName(122, "LC.gif");
            this.imglist_location.Images.SetKeyName(123, "LI.gif");
            this.imglist_location.Images.SetKeyName(124, "LK.gif");
            this.imglist_location.Images.SetKeyName(125, "LR.gif");
            this.imglist_location.Images.SetKeyName(126, "LS.gif");
            this.imglist_location.Images.SetKeyName(127, "LT.gif");
            this.imglist_location.Images.SetKeyName(128, "LU.gif");
            this.imglist_location.Images.SetKeyName(129, "LV.gif");
            this.imglist_location.Images.SetKeyName(130, "LY.gif");
            this.imglist_location.Images.SetKeyName(131, "MA.gif");
            this.imglist_location.Images.SetKeyName(132, "MC.gif");
            this.imglist_location.Images.SetKeyName(133, "MD.gif");
            this.imglist_location.Images.SetKeyName(134, "ME.gif");
            this.imglist_location.Images.SetKeyName(135, "MG.gif");
            this.imglist_location.Images.SetKeyName(136, "MH.gif");
            this.imglist_location.Images.SetKeyName(137, "MK.gif");
            this.imglist_location.Images.SetKeyName(138, "ML.gif");
            this.imglist_location.Images.SetKeyName(139, "MM.gif");
            this.imglist_location.Images.SetKeyName(140, "MN.gif");
            this.imglist_location.Images.SetKeyName(141, "MO.gif");
            this.imglist_location.Images.SetKeyName(142, "MP.gif");
            this.imglist_location.Images.SetKeyName(143, "MQ.gif");
            this.imglist_location.Images.SetKeyName(144, "MR.gif");
            this.imglist_location.Images.SetKeyName(145, "MS.gif");
            this.imglist_location.Images.SetKeyName(146, "MT.gif");
            this.imglist_location.Images.SetKeyName(147, "MU.gif");
            this.imglist_location.Images.SetKeyName(148, "MV.gif");
            this.imglist_location.Images.SetKeyName(149, "MW.gif");
            this.imglist_location.Images.SetKeyName(150, "MX.gif");
            this.imglist_location.Images.SetKeyName(151, "MY.gif");
            this.imglist_location.Images.SetKeyName(152, "MZ.gif");
            this.imglist_location.Images.SetKeyName(153, "NA.gif");
            this.imglist_location.Images.SetKeyName(154, "NC.gif");
            this.imglist_location.Images.SetKeyName(155, "NE.gif");
            this.imglist_location.Images.SetKeyName(156, "NF.gif");
            this.imglist_location.Images.SetKeyName(157, "NG.gif");
            this.imglist_location.Images.SetKeyName(158, "NI.gif");
            this.imglist_location.Images.SetKeyName(159, "NL.gif");
            this.imglist_location.Images.SetKeyName(160, "NO.gif");
            this.imglist_location.Images.SetKeyName(161, "noflag.gif");
            this.imglist_location.Images.SetKeyName(162, "NP.gif");
            this.imglist_location.Images.SetKeyName(163, "NR.gif");
            this.imglist_location.Images.SetKeyName(164, "NU.gif");
            this.imglist_location.Images.SetKeyName(165, "NZ.gif");
            this.imglist_location.Images.SetKeyName(166, "OM.gif");
            this.imglist_location.Images.SetKeyName(167, "PA.gif");
            this.imglist_location.Images.SetKeyName(168, "PE.gif");
            this.imglist_location.Images.SetKeyName(169, "PF.gif");
            this.imglist_location.Images.SetKeyName(170, "PG.gif");
            this.imglist_location.Images.SetKeyName(171, "PH.gif");
            this.imglist_location.Images.SetKeyName(172, "PK.gif");
            this.imglist_location.Images.SetKeyName(173, "PL.gif");
            this.imglist_location.Images.SetKeyName(174, "PR.gif");
            this.imglist_location.Images.SetKeyName(175, "PS.gif");
            this.imglist_location.Images.SetKeyName(176, "PT.gif");
            this.imglist_location.Images.SetKeyName(177, "PW.gif");
            this.imglist_location.Images.SetKeyName(178, "PY.gif");
            this.imglist_location.Images.SetKeyName(179, "QA.gif");
            this.imglist_location.Images.SetKeyName(180, "RE.gif");
            this.imglist_location.Images.SetKeyName(181, "RO.gif");
            this.imglist_location.Images.SetKeyName(182, "RS.gif");
            this.imglist_location.Images.SetKeyName(183, "RU.gif");
            this.imglist_location.Images.SetKeyName(184, "RW.gif");
            this.imglist_location.Images.SetKeyName(185, "SA.gif");
            this.imglist_location.Images.SetKeyName(186, "SB.gif");
            this.imglist_location.Images.SetKeyName(187, "SC.gif");
            this.imglist_location.Images.SetKeyName(188, "SD.gif");
            this.imglist_location.Images.SetKeyName(189, "SE.gif");
            this.imglist_location.Images.SetKeyName(190, "SG.gif");
            this.imglist_location.Images.SetKeyName(191, "SI.gif");
            this.imglist_location.Images.SetKeyName(192, "SK.gif");
            this.imglist_location.Images.SetKeyName(193, "SL.gif");
            this.imglist_location.Images.SetKeyName(194, "SM.gif");
            this.imglist_location.Images.SetKeyName(195, "SN.gif");
            this.imglist_location.Images.SetKeyName(196, "SO.gif");
            this.imglist_location.Images.SetKeyName(197, "SR.gif");
            this.imglist_location.Images.SetKeyName(198, "ST.gif");
            this.imglist_location.Images.SetKeyName(199, "SV.gif");
            this.imglist_location.Images.SetKeyName(200, "SY.gif");
            this.imglist_location.Images.SetKeyName(201, "SZ.gif");
            this.imglist_location.Images.SetKeyName(202, "TC.gif");
            this.imglist_location.Images.SetKeyName(203, "TD.gif");
            this.imglist_location.Images.SetKeyName(204, "TG.gif");
            this.imglist_location.Images.SetKeyName(205, "TH.gif");
            this.imglist_location.Images.SetKeyName(206, "TJ.gif");
            this.imglist_location.Images.SetKeyName(207, "TK.gif");
            this.imglist_location.Images.SetKeyName(208, "TM.gif");
            this.imglist_location.Images.SetKeyName(209, "TN.gif");
            this.imglist_location.Images.SetKeyName(210, "TO.gif");
            this.imglist_location.Images.SetKeyName(211, "TR.gif");
            this.imglist_location.Images.SetKeyName(212, "TT.gif");
            this.imglist_location.Images.SetKeyName(213, "TV.gif");
            this.imglist_location.Images.SetKeyName(214, "TW.gif");
            this.imglist_location.Images.SetKeyName(215, "TZ.gif");
            this.imglist_location.Images.SetKeyName(216, "UA.gif");
            this.imglist_location.Images.SetKeyName(217, "UG.gif");
            this.imglist_location.Images.SetKeyName(218, "UM.gif");
            this.imglist_location.Images.SetKeyName(219, "US.gif");
            this.imglist_location.Images.SetKeyName(220, "UY.gif");
            this.imglist_location.Images.SetKeyName(221, "UZ.gif");
            this.imglist_location.Images.SetKeyName(222, "VA.gif");
            this.imglist_location.Images.SetKeyName(223, "VC.gif");
            this.imglist_location.Images.SetKeyName(224, "VE.gif");
            this.imglist_location.Images.SetKeyName(225, "VG.gif");
            this.imglist_location.Images.SetKeyName(226, "VI.gif");
            this.imglist_location.Images.SetKeyName(227, "VN.gif");
            this.imglist_location.Images.SetKeyName(228, "VU.gif");
            this.imglist_location.Images.SetKeyName(229, "WF.gif");
            this.imglist_location.Images.SetKeyName(230, "WS.gif");
            this.imglist_location.Images.SetKeyName(231, "YE.gif");
            this.imglist_location.Images.SetKeyName(232, "YT.gif");
            this.imglist_location.Images.SetKeyName(233, "YU.gif");
            this.imglist_location.Images.SetKeyName(234, "ZA.gif");
            this.imglist_location.Images.SetKeyName(235, "ZM.gif");
            this.imglist_location.Images.SetKeyName(236, "ZW.gif");
            this.imglist_location.Images.SetKeyName(237, "ZZ.gif");
            // 
            // Btn_ToSub
            // 
            this.Btn_ToSub.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ToSub.Enabled = false;
            this.Btn_ToSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ToSub.Font = new System.Drawing.Font("굴림", 9F);
            this.Btn_ToSub.ImageKey = "send1";
            this.Btn_ToSub.ImageList = this.btn_imageList2;
            this.Btn_ToSub.Location = new System.Drawing.Point(90, 289);
            this.Btn_ToSub.Name = "Btn_ToSub";
            this.Btn_ToSub.Size = new System.Drawing.Size(67, 21);
            this.Btn_ToSub.TabIndex = 10;
            this.Btn_ToSub.Text = "Delete Note";
            this.Btn_ToSub.UseVisualStyleBackColor = false;
            this.Btn_ToSub.Click += new System.EventHandler(this.Btn_ToSub_Click);
            // 
            // btn_imageList2
            // 
            this.btn_imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btn_imageList2.ImageStream")));
            this.btn_imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.btn_imageList2.Images.SetKeyName(0, "send1");
            this.btn_imageList2.Images.SetKeyName(1, "send2");
            this.btn_imageList2.Images.SetKeyName(2, "send3");
            // 
            // ControlsBox
            // 
            this.ControlsBox.AutoScroll = true;
            this.ControlsBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ControlsBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlsBox.BackgroundImage")));
            this.ControlsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlsBox.Font = new System.Drawing.Font("굴림", 9F);
            this.ControlsBox.Location = new System.Drawing.Point(163, 20);
            this.ControlsBox.Name = "ControlsBox";
            this.ControlsBox.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ControlsBox.Size = new System.Drawing.Size(527, 350);
            this.ControlsBox.TabIndex = 24;
            this.ControlsBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlsBox_Paint);
            // 
            // Btn_ToAdd
            // 
            this.Btn_ToAdd.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ToAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ToAdd.Font = new System.Drawing.Font("굴림", 9F);
            this.Btn_ToAdd.ImageKey = "send1";
            this.Btn_ToAdd.ImageList = this.btn_imageList2;
            this.Btn_ToAdd.Location = new System.Drawing.Point(17, 289);
            this.Btn_ToAdd.Name = "Btn_ToAdd";
            this.Btn_ToAdd.Size = new System.Drawing.Size(67, 21);
            this.Btn_ToAdd.TabIndex = 6;
            this.Btn_ToAdd.Text = "Add Note";
            this.Btn_ToAdd.UseVisualStyleBackColor = false;
            this.Btn_ToAdd.Click += new System.EventHandler(this.Btn_ToAdd_Click);
            // 
            // Btn_Send_String
            // 
            this.Btn_Send_String.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Send_String.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Send_String.Font = new System.Drawing.Font("굴림", 9F);
            this.Btn_Send_String.ImageKey = "send1";
            this.Btn_Send_String.ImageList = this.imglst_btn_send;
            this.Btn_Send_String.Location = new System.Drawing.Point(17, 321);
            this.Btn_Send_String.Name = "Btn_Send_String";
            this.Btn_Send_String.Size = new System.Drawing.Size(140, 36);
            this.Btn_Send_String.TabIndex = 23;
            this.Btn_Send_String.Text = "send";
            this.Btn_Send_String.UseVisualStyleBackColor = false;
            this.Btn_Send_String.Click += new System.EventHandler(this.Btn_Send_String_Click);
            this.Btn_Send_String.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Send_String_MouseDown);
            this.Btn_Send_String.MouseLeave += new System.EventHandler(this.Btn_Send_String_MouseLeave);
            this.Btn_Send_String.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Send_String_MouseMove);
            // 
            // imglst_btn_send
            // 
            this.imglst_btn_send.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_btn_send.ImageStream")));
            this.imglst_btn_send.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_btn_send.Images.SetKeyName(0, "send1");
            this.imglst_btn_send.Images.SetKeyName(1, "send2");
            this.imglst_btn_send.Images.SetKeyName(2, "send3");
            // 
            // Num3_group
            // 
            this.Num3_group.BackColor = System.Drawing.Color.Transparent;
            this.Num3_group.Controls.Add(this.RTxt_FEE);
            this.Num3_group.Controls.Add(this.RTxt_TotalFasd);
            this.Num3_group.Font = new System.Drawing.Font("굴림", 9F);
            this.Num3_group.Location = new System.Drawing.Point(17, 165);
            this.Num3_group.Name = "Num3_group";
            this.Num3_group.Size = new System.Drawing.Size(140, 115);
            this.Num3_group.TabIndex = 22;
            this.Num3_group.TabStop = false;
            this.Num3_group.Text = "Info";
            // 
            // RTxt_FEE
            // 
            this.RTxt_FEE.BackColor = System.Drawing.Color.Silver;
            this.RTxt_FEE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxt_FEE.Enabled = false;
            this.RTxt_FEE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RTxt_FEE.Location = new System.Drawing.Point(6, 22);
            this.RTxt_FEE.Name = "RTxt_FEE";
            this.RTxt_FEE.ReadOnly = true;
            this.RTxt_FEE.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTxt_FEE.Size = new System.Drawing.Size(124, 32);
            this.RTxt_FEE.TabIndex = 17;
            this.RTxt_FEE.Text = "TotalFee";
            this.RTxt_FEE.Visible = false;
            // 
            // RTxt_TotalFasd
            // 
            this.RTxt_TotalFasd.BackColor = System.Drawing.Color.Silver;
            this.RTxt_TotalFasd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxt_TotalFasd.Enabled = false;
            this.RTxt_TotalFasd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RTxt_TotalFasd.Location = new System.Drawing.Point(6, 70);
            this.RTxt_TotalFasd.Name = "RTxt_TotalFasd";
            this.RTxt_TotalFasd.ReadOnly = true;
            this.RTxt_TotalFasd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTxt_TotalFasd.Size = new System.Drawing.Size(124, 32);
            this.RTxt_TotalFasd.TabIndex = 16;
            this.RTxt_TotalFasd.Text = "TotalGMB";
            this.RTxt_TotalFasd.Visible = false;
            // 
            // Num1_group
            // 
            this.Num1_group.BackColor = System.Drawing.Color.Transparent;
            this.Num1_group.Controls.Add(this.RTxt_Balance);
            this.Num1_group.Controls.Add(this.com_from);
            this.Num1_group.Font = new System.Drawing.Font("굴림", 9F);
            this.Num1_group.Location = new System.Drawing.Point(17, 7);
            this.Num1_group.Name = "Num1_group";
            this.Num1_group.Size = new System.Drawing.Size(140, 79);
            this.Num1_group.TabIndex = 21;
            this.Num1_group.TabStop = false;
            this.Num1_group.Text = "From";
            // 
            // RTxt_Balance
            // 
            this.RTxt_Balance.BackColor = System.Drawing.Color.Silver;
            this.RTxt_Balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxt_Balance.Enabled = false;
            this.RTxt_Balance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RTxt_Balance.Location = new System.Drawing.Point(9, 41);
            this.RTxt_Balance.Name = "RTxt_Balance";
            this.RTxt_Balance.ReadOnly = true;
            this.RTxt_Balance.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTxt_Balance.Size = new System.Drawing.Size(124, 32);
            this.RTxt_Balance.TabIndex = 18;
            this.RTxt_Balance.Text = "Balance";
            this.RTxt_Balance.Visible = false;
            // 
            // com_from
            // 
            this.com_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_from.FormattingEnabled = true;
            this.com_from.Location = new System.Drawing.Point(9, 15);
            this.com_from.Name = "com_from";
            this.com_from.Size = new System.Drawing.Size(121, 20);
            this.com_from.TabIndex = 18;
            this.com_from.SelectedIndexChanged += new System.EventHandler(this.com_from_SelectedIndexChanged);
            this.com_from.MouseHover += new System.EventHandler(this.com_from_MouseHover);
            // 
            // Num2_group
            // 
            this.Num2_group.BackColor = System.Drawing.Color.Transparent;
            this.Num2_group.Controls.Add(this.radio_Private);
            this.Num2_group.Controls.Add(this.radio_Public);
            this.Num2_group.Font = new System.Drawing.Font("굴림", 9F);
            this.Num2_group.Location = new System.Drawing.Point(17, 92);
            this.Num2_group.Name = "Num2_group";
            this.Num2_group.Size = new System.Drawing.Size(140, 67);
            this.Num2_group.TabIndex = 20;
            this.Num2_group.TabStop = false;
            this.Num2_group.Text = "Note Privacy";
            // 
            // radio_Private
            // 
            this.radio_Private.AutoSize = true;
            this.radio_Private.ForeColor = System.Drawing.Color.White;
            this.radio_Private.Location = new System.Drawing.Point(6, 20);
            this.radio_Private.Name = "radio_Private";
            this.radio_Private.Size = new System.Drawing.Size(61, 16);
            this.radio_Private.TabIndex = 14;
            this.radio_Private.Text = "Private";
            this.radio_Private.UseVisualStyleBackColor = true;
            // 
            // radio_Public
            // 
            this.radio_Public.AutoSize = true;
            this.radio_Public.Checked = true;
            this.radio_Public.ForeColor = System.Drawing.Color.White;
            this.radio_Public.Location = new System.Drawing.Point(6, 42);
            this.radio_Public.Name = "radio_Public";
            this.radio_Public.Size = new System.Drawing.Size(58, 16);
            this.radio_Public.TabIndex = 13;
            this.radio_Public.TabStop = true;
            this.radio_Public.Text = "Public";
            this.radio_Public.UseVisualStyleBackColor = true;
            // 
            // Btn_Send_Byte
            // 
            this.Btn_Send_Byte.Enabled = false;
            this.Btn_Send_Byte.Location = new System.Drawing.Point(17, 321);
            this.Btn_Send_Byte.Name = "Btn_Send_Byte";
            this.Btn_Send_Byte.Size = new System.Drawing.Size(136, 36);
            this.Btn_Send_Byte.TabIndex = 0;
            this.Btn_Send_Byte.Text = "전송";
            this.Btn_Send_Byte.UseVisualStyleBackColor = true;
            this.Btn_Send_Byte.Visible = false;
            this.Btn_Send_Byte.Click += new System.EventHandler(this.Btn_Send_Byte_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.keyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.RenameToolStripMenuItem,
            this.Separator1,
            this.CreateToolStripMenuItem});
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.keyToolStripMenuItem.Text = "Key";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.keyToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RenameToolStripMenuItem.Text = "Rename";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(177, 6);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateToolStripMenuItem.Text = "Generate";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // btx_exit
            // 
            this.btx_exit.BackColor = System.Drawing.Color.Transparent;
            this.btx_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btx_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btx_exit.ImageKey = "1";
            this.btx_exit.ImageList = this.imglst_util;
            this.btx_exit.Location = new System.Drawing.Point(696, 0);
            this.btx_exit.Name = "btx_exit";
            this.btx_exit.Size = new System.Drawing.Size(24, 24);
            this.btx_exit.TabIndex = 17;
            this.btx_exit.UseVisualStyleBackColor = false;
            this.btx_exit.Click += new System.EventHandler(this.btx_exit_Click);
            this.btx_exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btx_exit_MouseDown);
            this.btx_exit.MouseLeave += new System.EventHandler(this.btx_exit_MouseLeave);
            this.btx_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btx_exit_MouseMove);
            // 
            // imglst_util
            // 
            this.imglst_util.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_util.ImageStream")));
            this.imglst_util.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_util.Images.SetKeyName(0, "3");
            this.imglst_util.Images.SetKeyName(1, "1");
            this.imglst_util.Images.SetKeyName(2, "2");
            this.imglst_util.Images.SetKeyName(3, "33");
            this.imglst_util.Images.SetKeyName(4, "11");
            this.imglst_util.Images.SetKeyName(5, "22");
            // 
            // btn__
            // 
            this.btn__.BackColor = System.Drawing.Color.Transparent;
            this.btn__.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn__.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn__.ImageKey = "11";
            this.btn__.ImageList = this.imglst_util;
            this.btn__.Location = new System.Drawing.Point(674, 0);
            this.btn__.Name = "btn__";
            this.btn__.Size = new System.Drawing.Size(24, 24);
            this.btn__.TabIndex = 18;
            this.btn__.UseVisualStyleBackColor = false;
            this.btn__.Click += new System.EventHandler(this.btn___Click);
            this.btn__.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn___MouseDown);
            this.btn__.MouseLeave += new System.EventHandler(this.btn___MouseLeave);
            this.btn__.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn___MouseMove);
            // 
            // btn_FormExtend
            // 
            this.btn_FormExtend.Location = new System.Drawing.Point(708, 195);
            this.btn_FormExtend.Name = "btn_FormExtend";
            this.btn_FormExtend.Size = new System.Drawing.Size(12, 23);
            this.btn_FormExtend.TabIndex = 19;
            this.btn_FormExtend.Text = ">";
            this.btn_FormExtend.UseVisualStyleBackColor = true;
            this.btn_FormExtend.Visible = false;
            this.btn_FormExtend.Click += new System.EventHandler(this.btn_FormExtend_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(580, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "                   ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel3.Text = "0000-00-00 00:00:00";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::TXClient.Properties.Resources.main_bac;
            this.ClientSize = new System.Drawing.Size(720, 436);
            this.Controls.Add(this.btn_FormExtend);
            this.Controls.Add(this.btn__);
            this.Controls.Add(this.btx_exit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GMB Wallet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Num3_group.ResumeLayout(false);
            this.Num1_group.ResumeLayout(false);
            this.Num2_group.ResumeLayout(false);
            this.Num2_group.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Tim_Time;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFileDialog_prikey;
        public System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Send_Byte;
        public System.Windows.Forms.Button Btn_ToSub;
        public System.Windows.Forms.Button Btn_ToAdd;
        public System.Windows.Forms.RichTextBox RTxt_FEE;
        public System.Windows.Forms.RichTextBox RTxt_TotalFasd;
        public System.Windows.Forms.ComboBox com_from;
        private System.Windows.Forms.Button Btn_Send_String;
        public System.Windows.Forms.FlowLayoutPanel ControlsBox;
        private System.Windows.Forms.ImageList imglst_util;
        private System.Windows.Forms.ImageList imglst_btn_send;
        private System.Windows.Forms.ImageList btn_imageList2;
        public System.Windows.Forms.RichTextBox RTxt_Balance;
        private System.Windows.Forms.Button btn_FormExtend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.GroupBox Num1_group;
        public System.Windows.Forms.GroupBox Num2_group;
        public System.Windows.Forms.GroupBox Num3_group;
        public System.Windows.Forms.Button btx_exit;
        public System.Windows.Forms.Button btn__;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.RadioButton radio_Public;
        public System.Windows.Forms.RadioButton radio_Private;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList imglist_location;
        public System.Windows.Forms.Button btn_location_ico;
        private System.Windows.Forms.Label lbl_location;
    }
}

