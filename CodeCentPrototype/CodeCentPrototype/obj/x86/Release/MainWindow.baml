   M S B A M L   `   `   `  ���� `  \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35tNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary!Microsoft.Windows.Controls.Ribbon   CodeCentPrototype"   CodeCentPrototype.MainWindow   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    _ribbonNclr-namespace:Microsoft.Windows.Controls.Ribbon;assembly=RibbonControlsLibrary    >d2http://schemas.microsoft.com/expression/blend/2008    Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    -   4   .Microsoft.Windows.Controls.Ribbon.RibbonWindow   Name$  RibbonWindow�� � Title$ CodeCent Manager��$
��Auto��$
��Auto��.��� -    �Name$ 
LayoutRoot��$	��827�� � RowDefinitions �� $	��759 ��� $	��68* �.+�.   (Microsoft.Windows.Controls.Ribbon.Ribbon  -     Name$ Ribbon��$��0,0,0,65q�   ApplicationMenu =   7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  8   2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   Label$
 File�� o� 
IsMainMenu .    SmallImageSource$7 1/CodeCentPrototype;component/Images/fileSmall.png��.@�A   ;Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem  -   	  Name$	 
ButtonExit��$
��Exit��6   0Microsoft.Windows.Controls.Ribbon.RibbonMenuItem
   ImageSource$7
 1/CodeCentPrototype;component/Images/exitLarge.png��.@�1   +Microsoft.Windows.Controls.Ribbon.RibbonTab  -     Name$ HomeTab��$
��Home��.@�3   -Microsoft.Windows.Controls.Ribbon.RibbonGroup  -     Name$ RibbonGroupMain��$
��Main��.@�4	   .Microsoft.Windows.Controls.Ribbon.RibbonButton	  -    	 Name$  RibbonButtonNewApplication�� 	  LargeImageSource$8 2/CodeCentPrototype;component/Images/newSTLarge.png�� 	  Label$ New Student From Email��	  -   $ RibbonButtonNew�� 	  SmallImageSource$8 2/CodeCentPrototype;component/Images/newSTLarge.png��$ New Student��	  -	   $ RibbonButtonSearch��$9 3/CodeCentPrototype;component/Images/searchSmall.png��$ Search��  -
   $ RibbonGroupStudent��$��Student Record��.@�	  -   $ RibbonButtonUnlockRecord��$ Unlock For Editing��{�. $9 3/CodeCentPrototype;component/Images/unlockLarge.png��	  -   $ RibbonButtonPrint��$8 2/CodeCentPrototype;component/Images/printSmall.png��$ Print Record��{�. 	  -   $ RibbonButtonSave��$ Save Changes��{�. $7 1/CodeCentPrototype;component/Images/saveSmall.png��  -   $ RibbonGroupClipboard��$��	Clipboard��.@�	  -   $ RibbonButtonPaste��$ Paste��{�. $8 2/CodeCentPrototype;component/Images/pasteLarge.png��	  -   $ RibbonButtonCut��$	 Cut��{�. $6 0/CodeCentPrototype;component/Images/cutSmall.png��	  -   $ RibbonButtonCopy��$
 Copy��{�. $7 1/CodeCentPrototype;component/Images/copySmall.png��  -   $ RibbonTabTools��$��Tools��.@�  -   $ RibbonGroupReporting��$��	Reporting��.@�	  -   $ RibbonButtonRunReport��$< 6/CodeCentPrototype;component/Images/reportingLarge.png��$ 
Run Report��	  -   $ RibbonButtonExport��$8 2/CodeCentPrototype;component/Images/excelSmall.png��$ Export to Excel��  -   $ RibbonGroupBackupRestore��.@�	  -   $ RibbonButtonBackup��$9 3/CodeCentPrototype;component/Images/backupLarge.png��$ Backup��	  -   $ RibbonButtonRestore��$ Restore��$: 4/CodeCentPrototype;component/Images/restoreLarge.png��  -   $ RibbonGroupSettings��.@�	  -   $ RibbonButtonOptions��$: 4/CodeCentPrototype;component/Images/optionsLarge.png��$ Options��  -   $ RibbonTabHelp��$
��Help��.@�  -   $ RibbonGroupHelp��$�� ��.@�	  -   $ RibbonButtonHelp��$7 1/CodeCentPrototype;component/Images/helpLarge.png��$
 Help��  -   $ RibbonGroupAbout��$�� ��.@�	  -   $ RibbonButtonAbout��$7 1/CodeCentPrototype;component/Images/infoLarge.png��$ About���� -    $��ProfileTabControl��$��235,141,12,8q�.@��� -!    ��Name$ 
tabProfile��$��Profile��$��16(���Z� .��� 
������� � ColumnDefinitions �� $	��381 ��� $	��577 �.+��� -"    ��Name$ groupContactInformation��$��Contact Information��$��2,187,14,52q�$��16(�$��2��.��� $��Stretch=�$��Stretch=�.+��� -#   $��labelAddress��$��Address��$��16(�$��31.28��$
��Left=�$��	10,10,0,0q�$	��Top=��� -$   $��	labelCity��$
��City��$��16(�$
��Left=�$��	10,51,0,0q�$	��Top=��� -%   $��
labelState��$��State��$��16(�$
��Left=�$��
415,51,0,0q�$	��Top=�$��48.61���� -&   $��labelZip��$	��Zip��$��16(�$
��Left=�$��
590,53,0,0q�$	��Top=�$��48.61���� -'   $��labelHomePhone��$��
Home Phone��$��16(�$
��Left=�$��	10,83,0,0q�$	��Top=��� -(   $��labelCellPhone��$��
Cell Phone��$��16(�$
��Left=�$��
10,128,0,0q�$	��Top=�$��84.523���� -)   $��labelEmailAddress��$��Email Address��$��16(�$
��Left=�$��
10,206,0,0q�$	��Top=��� -*   $��labelCWUEmailAddress��$��CWU Email Address��$��16(�$
��Left=�$��
10,168,0,0q�$	��Top=��� -+   $��textAddress��$��28��$��81,13,449,0q� �� TextWrapping$
 Wrap=�$	��Top=��� -,   $��textCity��$��28��$
��Left=�$��	62,51,0,0q�$
 Wrap=�$	��Top=�$��274.568���� --   $��	textState��$��28��$��
467,53,0,0q�$
 Wrap=�$	��Top=�$
��Left=�$��41���� -.   $��textZIPCode��$��28��$��Right=�$��
0,54,197,0q�$
 Wrap=�$	��Top=�$��107.478���� -/   $��textHomePhone��$��28��$
��Left=�$��
128,91,0,0q�$
 Wrap=�$	��Top=�$��208.222���� -0   $��textCellPhone��$��28��$
��Left=�$��116,129,0,0q�$
 Wrap=�$	��Top=�$��220.445���� -1   $��textCWUEmailAddress��$��28��$
��Left=�$��172,168,0,0q�$
 Wrap=�$	��Top=�$��315.442���� -2   $��textEmailAddress��$��28��$
��Left=�$��128,207,0,0q�$
 Wrap=�$	��Top=�$��359.442���� -3   $ groupStudentInformation��$��Student Information��$	��Top=�$��8,8,8,0q�$	��161��$��16(�$��2��.��� $��Stretch=�$��Stretch=� �� $	��309 ��� $	��225 ��� $	��379 �.+��� -4   $��labelLastName��$��	Last Name��$��16(�$
��Left=�$��	16,52,0,0q�$	��Top=��� -5   $��labelFirstName��$��
First Name��$��16(�$
��Left=�$��	13,16,0,0q�$	��Top=�$��89.77���� -6   $��labelMiddleInitial��$��Middle Initial��$��
100,13,6,0q�$	��Top=�$	��118��$��1���� -7   $��labelBirthday��$��	Birthdate��$
��Left=�$��
100,52,0,0q�$	��Top=�$��78.934��$��1���� -8   $��labelStudentID��$��
Student ID��$��16(�$
��Left=�$��	12,89,0,0q�$	��Top=��� -9   $��textLastName��$��28��$��Right=�$��
0,55,181,0q�$
 Wrap=�$	��Top=�$	��247��$��2���� -:   $��textFirstName��$��28��$��Right=�$��
0,17,181,0q�$
 Wrap=�$	��Top=�$��246.944��$��2���� -;   $��textStudentID��$��28��$��Right=�$��
0,92,181,0q�$
 Wrap=�$	��Top=�$	��247��$��2���� -<   $��textMiddleInitial��$��28��$��Right=�$��
0,16,280,0q�$
 Wrap=�$	��Top=�$��98.836��$��2���� -=   $��textBirthday��$��28��$��Right=�$��
0,52,280,0q�$
 Wrap=�$	��Top=�$��128.836��$��2��$��1���� ->   $ 
tabDetails��$��Details��$��16(���Z� .��� 
�������.+��� -?   $ groupGeneral��$��General��$��8,8,8,0q�$��294.18��$	��Top=��� -@   $ groupTestScores��$"��Test Scores and Transfer GPA��$��8,306.18,8,32q�.��� .+��� -A   $��labelCollegeGPA��$��College GPA��$��16(�$
��Left=�$��	519,5,0,0q�$	��Top=��� -B   $��
labelHSGPA��$��HS GPA��$��16(�$
��Left=�$��542,0,0,128q�$��Bottom=��� -C   $��textGPA��$��28��$
��Left=�$��623,0,0,171q�$
 Wrap=�$��Bottom=�$��98.847���� -D   $��	textHSGPA��$��28��$
��Left=�$��623,0,0,128q�$
 Wrap=�$��Bottom=�$��98.847���� -E    ��Name$ textDateOfDirectorAction��$��
0,0,191,93q�$
 Wrap=�$��Bottom=�$��Right=�$��197.847��$��28���� -F    ��Name$ labelDateOfDirectorAction��$
��Date��$
��Left=�$��
466,0,0,94q�$��Bottom=�$��16(��� -G   $ labelClassStanding��$��Class Standing��$
��Left=�$��16,38.04,0,0q�$	��Top=�$��16(��� -H   $ labelQuarterEnteredCWU��$��Quarter Entered CWU��$
��Left=�$��	16,80,0,0q�$	��Top=�$��16(��� -I   $ labelQuarterEnteredDHC��$��Quarter Entered DHC��$��461.693,78.5,385.59,0q�$	��Top=��� -J   $ labelCWUAppStatus��$��CWU App Status��$��461.523,38.04,418.4,0q�$	��Top=��� -K   $ labelCurrentCWUStudent��$��Current CWU Student��$
��Left=�$��16,117.46,0,0q�$	��Top=�$��16(��� -L   $ labelDateReceived��$��Date Received��$��461.693,118.92,434.753,0q�$	��Top=��� -M   $ labelFirstYearOrUDSE��$��First Year or UDSE��$
��Left=�$��16,159.42,0,0q�$	��Top=�$��16(��� -N   $ labelAI��$��AI��$
��Left=�$��
22,333,0,0q�$��16(�$	��Top=��� -O   $ labelSAT��$	��SAT��$
��Left=�$��
22,375,0,0q�$��16(�$	��Top=��� -P   $ labelACT��$	��ACT��$
��Left=�$��21.95,411.96,0,421.52q�$��16(��� -Q   $ labelTransfer��$��Transfer��$��461.693,159.42,478.44,0q�$	��Top=��� -R   $ labelFirstYearOrUDSE_Copy��$��Core or Hybrid��$
��Left=�$��16,201.38,0,0q�$	��Top=�$��16(��� -S   $ labelDirectorAction��$��Director Action��$��
21,0,0,129q�$��Bottom=�$��16(�$
��Left=�$��116.947���� -T   $ textQuarterEnteredCWU��$��192.077,83.28,0,0q�$
 Wrap=�$	��Top=�$
��Left=�$��127.31��$��28���� -U   $ textQuarterEnteredDHC��$��0,83.28,259.98,0q�$
 Wrap=�$	��Top=�$��Right=�$��108.11��$��28���� -V   $ textAI��$��63,336,541,0q�$
 Wrap=�$	��Top=�$��28��$	��337���� -W   $ textSAT��$��63,378,542,0q�$
 Wrap=�$	��Top=�$��28��$	��336���� -X   $ textACT��$!��64.68,414.68,468.027,422.08q�$
 Wrap=��� -Y    ��Name$ comboClassStanding��$��140.083,41.32,0,0q�$	��Top=�$
��Left=�$��280.537��$��28�� �� 
IsEditable . ��Z� .@��� $��1 First Year���� $��2 Sophomore���� $��3 Junior���� $��4 Senior���� -Z   $ comboCurrentCWUStudent��$��192.077,120.74,0,0q�$	��Top=�$��28��$
��Left=�$��127.31�� . ��Z� .@��� $	��Yes���� $��No���� -[   $ comboFirstYearorUDSE��$��172.783,162.7,0,0q�$	��Top=�$��28��$
��Left=�$��247.837�� . ��Z� .@��� $��Upper-Division A&H���� $��Upper-Division SHP���� -\   $ comboCoreOrHybrid��$��140.083,204.66,0,0q�$	��Top=�$��28��$
��Left=�$��280.537�� . ��Z� .@��� $��DHC Breadth���� $��CWU Breadth���� -]   $ comboTransfer��$��0,162.42,382.59,0q�$	��Top=�$��Right=�$��85.81�� . ��Z� .@��� $	��Yes���� $��No���� -^   $ comboCWUAppStatus��$��0,42.04,289.98,0q�$	��Top=�$��Right=�$��108.11�� . ��Z� .@��� $��AP���� $��AD���� $��PM���� $��M���� $��
Cancel-DHC���� $��
Cancel-CWU���� -_   $ textDateReceived��$��0,121.46,309.98,0q�$
 Wrap=�$	��Top=�$��Right=�$��108.11���� -`   $ comboDirectorAction��$��144,0,0,132q�$��Bottom=�$
��Left=�$��256.363��$��28�� . ��Z� .@��� $��Warning���� $��	Suspended���� $��Accepted���� $��Denied���� -a   $ labelGraduatedOrWithdrawn��$��Status in Program��$
��Left=�$��16,243.84,0,0q�$��16(�$��32��$	��Top=��� -b   $ comboGraduatedOrWithdrawn��$��172.783,247.84,0,0q�$��28��$	��Top=�$
��Left=�$��247.837�� . ��Z� .@��� $#��Completed Breath Requirements���� $��	Graduated���� $��	Withdrawn�� � BindingGroup &
   System.Windows.Data.BindingGroup
  �� $��	Suspended�� 
  �� $��	Probation���� $��On Leave���� $��Study Abroad���� $��Course Grades��$��16(���Z� .��� 
�������.+��� -c   $��SHPCourseGroupbox��$��SHP Courses��$��	9,421,7,0q�$��95.78��$	��Top=�.��� $��Stretch=�$��Stretch=�.+��� -d   $��comboSHP399��$��28��$
��Left=�$��	72,19,0,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -e   $��comboSHP401��$��28��$
��Left=�$��
264,19,0,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -f   $��comboSHP497��$��28��$��458,21,435,0q�$	��Top=� . ��Z� .@��� $
��Pass���� $
��Fail���� -g   $��label141_Copy15��$	��399��$��16(�$
��Left=�$��	25,19,0,0q�$	��Top=��� -h   $��label141_Copy16��$	��401��$��16(�$
��Left=�$��
220,19,0,0q�$	��Top=��� -i   $��label141_Copy17��$	��497��$��16(�$
��Left=�$��
410,19,0,0q�$	��Top=��� $��General��$��8,409.24,8,331.5q��� -j   $ groupGPADetail��$��
GPA Detail��$��8,8,8,0q�$	��Top=�$��84��$��16(�.��� $��Stretch=�$��Stretch=�.+��� -k   $��labelCurrentQuarterGPA��$��Current Quarter GPA��$��16(�$
��Left=�$��	10,10,0,0q�$	��Top=��� -l   $��labelPriorQuarterGPA��$��Prior Quarter GPA��$��16(�$��Right=�$��
0,10,236,0q�$	��Top=�$��148.1���� -m   $��textCurrentQuarterGPA��$��28��$
��Left=�$��
170,14,0,0q�$
 Wrap=�$	��Top=�$��77.071���� -n   $��textPriorQuarterGPA��$��28��$��Right=�$��
0,11,152,0q�$
 Wrap=�$	��Top=�$
��79.9���� -o   $��labelCummulativeGPA��$��Cumulative GPA��$��16(�$
��Left=�$��
331,11,0,0q�$	��Top=��� -p   $��textCumulativeGPA��$��28��$��459,13,443,0q�$
 Wrap=�$	��Top=��� -q   $ groupGPADetail1��$��DHC Courses��$��8,95,8,0q�$��16(�$	��324��$	��Top=�.��� -r   $��DHCCourseGrid��$��Stretch=�$��Stretch=�.+��� -s   $��labelMathRequirement��$��Math Requirement Complete��$��16(�$
��Left=�$��	41,0,0,28q�$��Bottom=��� -t   $��labelLanguageRequirement��$#��Language Requirement Complete��$��16(�$
��Left=�$��	13,0,0,76q�$��Bottom=��� -u   $��comboMathRequirement��$��28��$
��Left=�$��
265,0,0,31q�$��Bottom=�$��85.844�� . ��Z� .@��� $	��Yes���� $��No���� -v   $��comboLanguageRequirement��$��28��$
��Left=�$��
265,0,0,75q�$��Bottom=�$��85�� . ��Z� .@��� $	��Yes���� $��No���� -w   $��combo140��$��28��$
��Left=�$��	58,12,0,0q�$	��Top=�$��85�� . ��Z�  � DataContext �� ���� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -x   $��combo141��$��28��$
��Left=�$��	58,58,0,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -y   $��combo150��$��28��$
��Left=�$��
58,102,0,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -z   $��combo151��$��28��$
��Left=�$��
58,142,0,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -{   $��combo251��$��28��$
��Left=�$��250,142,0,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -|   $��combo250��$��28��$
��Left=�$��250,100,0,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -}   $��combo161��$��28��$
��Left=�$��
250,58,0,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -~   $��combo160��$��28��$
��Left=�$��
250,12,0,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -   $��combo260��$��28��$��444,12,384,0q�$
��Left=�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -�   $��combo261��$��28��$��444,58,384,0q�$
��Left=�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -�   $��combo270��$��28��$��444,102,0,0q�$	��Top=�$��85��$
��Left=� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -�   $��combo301��$��28��$��444,142,384,0q�$	��Top=�$
��Left=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -�   $��combo497��$��28��$��Right=�$��0,144,235,0q�$	��Top=�$��85�� . ��Z� .@��� $
��Pass���� $
��Fail���� -�   $��combo401��$��28��$��Right=�$��
0,99,235,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -�   $��combo399��$��28��$��Right=�$��
0,55,235,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -�   $��combo380��$��28��$��Right=�$��
0,10,235,0q�$	��Top=�$��85�� . ��Z� .@��� $��A���� $��A-���� $��B+���� $��B���� $��B-���� $��C+���� $��C���� $��C-���� $��D+���� $��D���� $��D-���� $��F���� $��I���� -�   $��label141��$	��140��$��16(�$
��Left=�$��	10,10,0,0q�$	��Top=��� -�   $��label141_Copy��$	��141��$��16(�$
��Left=�$��	10,56,0,0q�$	��Top=��� -�   $��label141_Copy1��$	��150��$��16(�$
��Left=�$��
10,102,0,0q�$	��Top=��� -�   $��label141_Copy2��$	��151��$��16(�$
��Left=�$��
10,142,0,0q�$	��Top=��� -�   $��label141_Copy3��$	��160��$��16(�$
��Left=�$��
205,10,0,0q�$	��Top=��� -�   $��label141_Copy4��$	��161��$��16(�$
��Left=�$��
205,56,0,0q�$	��Top=��� -�   $��label141_Copy5��$	��250��$��16(�$
��Left=�$��205,102,0,0q�$	��Top=��� -�   $��label141_Copy6��$	��251��$��16(�$
��Left=�$��205,142,0,0q�$	��Top=��� -�   $��label141_Copy7��$	��260��$��16(�$
��Left=�$��
396,10,0,0q�$	��Top=��� -�   $��label141_Copy8��$	��261��$��16(�$
��Left=�$��
396,56,0,0q�$	��Top=��� -�   $��label141_Copy9��$	��270��$��16(�$
��Left=�$��396,102,0,0q�$	��Top=��� -�   $��label141_Copy10��$	��301��$��16(�$
��Left=�$��396,142,0,0q�$	��Top=��� -�   $��label141_Copy11��$	��380��$��16(�$��Right=�$��
0,10,333,0q�$	��Top=��� -�   $��label141_Copy12��$	��399��$��16(�$��Right=�$��
0,56,333,0q�$	��Top=��� -�   $��label141_Copy13��$	��401��$��16(�$��Right=�$��0,102,333,0q�$	��Top=��� -�   $��label141_Copy14��$	��497��$��16(�$��Right=�$��0,142,333,0q�$	��Top=��� -�   $ tabAttachments��$��Attachments��$��16(���Z� .��� 
������� �� $��0.142* ��� $��0.858* �.+��� -�   $ groupComments��$��Comments��$��8,8,8,0q�$	��Top=�$��298.46��$��2��.���� -�   $��textComments��$
 Wrap=��� -�   $ groupAttachedFiles��$��Attached Files��$��8,310.46,8,369.22q�$��2��.���� -�    ��Name$ 	listFiles���� -�   $��	groupBox1��$��Attached Files��$	��255��$��	8,312,8,0q�$	��Top=�$��2��.���� -�   $��textBox1��$
 Wrap=��� -�   $ 	comboYear��$
��Left=�$��4,0,0,8q�$��Bottom=�$	��227��$��28�� �� SelectedIndex$ 0��$��16(���Z� .@��� $
��Year���� $��	2011-2012���� $��	2010-2011���� $��	2009-2010���� -�   $ comboClassStanding_Copy��$��	4,0,0,121q�$��Bottom=�$
��Left=�$	��227��$��28��$ 0��$��16(���Z� .@��� $��Class Standing���� $��1 First Year���� $��2 Sophomore���� $��3 Junior���� $��4 Senior���� $
��Left=�$��	4,141,0,0q�$
 Wrap=�$��	Search...��$	��Top=�$��184.553��$��16(�$��28���� $��Go��$
��Left=�$��193,142,0,0q�$	��Top=�$��38.447��$��16(���Z� �� -�   $ listStudents��$
��Left=�$��4,173,0,155q�$	��227��$��16(��� -�   $ comboClassStanding_Copy1��$��4,0,0,44q�$��Bottom=�$
��Left=�$	��227��$��28��$ 0��$��16(���Z� .@��� $��Program���� $	��DHC���� $	��SHP���� -�   $ comboClassStanding_Copy2��$��4,0,0,83q�$��Bottom=�$
��Left=�$	��227��$��28��$ 0��$��16(���Z� .@��� $��Breadth���� $	��DHC���� $	��CWU��