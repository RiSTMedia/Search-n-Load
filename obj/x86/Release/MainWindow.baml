   M S B A M L   `   `   `  ���� H  DSearch_n_Load, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Search_n_LoadSearch_n_Load  U QVlc.DotNet.Wpf, Version=1.2.0.0, Culture=neutral, PublicKeyToken=84529da31f4eb963G4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.WpfVlc.DotNet.Wpf *    $Search_n_Load.searchnload.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     +snlclr-namespace:Search_n_Load     Dvlc4clr-namespace:Vlc.DotNet.Wpf;assembly=Vlc.DotNet.Wpf     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Search 'n' Load��$	��811�� � 
ResizeMode$ NoResize=� � SizeToContent$ Height=�.��� .+�o� -   $��Menu1��$	��Top=�$��22��.@�m� $��Datei��m� $��
Bearbeiten��m� $��Download��m� $��?���� -   $��	ComboBox1��$��23��$��
0,28,158,0q�$	��Top=�$��Right=�$��86��.@��� $
��Song���� $��Video���� $
��Info���� -   $��Button1��$��Search��$��31��$��	0,23,12,0q�$	��Top=�$��Right=�$	��140���� -   $��	ListView1��$��12,64,351,0q�$	��363��$	��Top=� �� View ��  �� AllowsColumnReorder .  .P���  �� CellTemplate ��  � 	Resources    Search_n_Load.converter   thumbnailtobild��%   &	          .R�� .+��� $��50��$
��Left=����� *
Thumbnails+ �� 	Converter# [  ��  �� .R��� $��2,0,0,0q����� *Title+��  �� .R��� -   $<��6/Search_n_Load;component/Images/image_0001_Ebene-0.png��$��28����  �� .R��� -   $<��6/Search_n_Load;component/Images/image_0000_Ebene-1.png��$��28��9� -   $��	Expander1��$��	Expander1��$��12,434,12,-1q�.��� $��38��.+��� -   $��Button2��$��Browse��$��28��$
��Left=�$��	397,3,0,0q�$	��Top=�$	��114���� -	   $��TextBox2��$��21��$
��Left=�$��6,6,0,0q�$	��Top=�$	��385���� -
   $��	ComboBox2��$��28��$
��Left=�$��	517,3,0,0q�$	��Top=�$	��118��.@��� $
��Song���� $��Video���� -   $��	ComboBox3��$��23��$
��Left=�$��	12,28,0,0q�$	��Top=�$	��527�� �� 
IsEditable . � $��452,75,12,227q�.+�  Vlc.DotNet.Wpf.VlcControl  -   	  Name$	 myVlcControl����!� 
 j� Stretch$
 Uniform=� !� Visual �� ����  �� ElementName$ myVlcControl�� �� Path$ VideoSource�