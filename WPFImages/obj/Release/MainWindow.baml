   M S B A M L   `   `   `  ���� D  @WPFImages, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFImages	WPFImages      WPFImages.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:WPFImages     -     � Title$  Images test��$	��600��$	��800�� � WindowStartupLocation$ CenterScreen=� J� 	AllowDrop .  � 	Resources    NormalBrush �� EndPoint �� 
StartPoint � Color � Offset  PressedBrush  NormalBorderBrush  BorderBrush  PressedBorderBrush  SimpleButton �� 
TargetType	 �� Triggers
 P� Property P� Value �� Property �� Value �� 
TargetType �Name ��Name �� Padding ��Name �� Triggers �� 
TargetName��%p  &	        &	 �     &	 z    &	 
    &	 �    &	 -    7   7  7  7  �� LinearGradientBrush_1��$	 0,1&�$	 0,0&�.��� GradientStop_1��$
 #FFF��$	 0.0Q�� GradientStop_2��$
 #CCC��$	 1.0Q��� LinearGradientBrush_2��$	 0,1&�$	 0,0&�.��� GradientStop_3��$
 #BBB��$	 0.0Q�� GradientStop_4��$
 #EEE��$	 0.1Q�� GradientStop_5��$
 #EEE��$	 0.9Q�� GradientStop_6��$
 #FFF��$	 1.0Q��� LinearGradientBrush_3��$	 0,1&�$	 0,0&�.��� GradientStop_7��$
 #CCC��$	 0.0Q�� GradientStop_8��$
 #444��$	 1.0Q��� LinearGradientBrush_4��$	 0,1&�$	 0,0&�.��� GradientStop_9��$
 #CCC��$	 0.0Q�� GradientStop_10��$
 #444��$	 1.0Q��� LinearGradientBrush_5��$	 0,1&�$	 0,0&�.��� GradientStop_11��$
 #444��$	 0.0Q�� GradientStop_12��$
 #888��$	 1.0Q��� Style_1��" ��	 P� 	Trigger_1��
 � {� .  . ��� Setter_1�� � ��
 �����.��� Setter_2�� � ��8   �� Setter_3�� � ��8  �� Setter_4�� � �� �� ControlTemplate_1��" ��.R�� $
 Grid��Grid��.+��� $ Border��
Border��#��z��#��z��#��z��# z���� $ Content��Content��#��z��#��z��#��z����.  P� 	Trigger_2��
 � �� . . ��� Setter_5��8  $ Border�� � ���� Setter_6��8  $ Border�� � ��.��� -   $ gridMain��.+��� -    ��Name$ ScrollViewerImages��$��0��$y�Visible=�$
��Auto=�$��10q�$��Stretch=�$��Stretch=�.��� -    �Name$ WrapPanelImages��$��2�� ��%[   '��       �� " ��.���  � ��$ 20q���  � ��$	 200����  � ��$	 200��� -   $ 	GridImage��$��0��$y�	Collapsed=� � ColumnDefinitions �� $	��10* ��� $	��100 �.+�� -   $
 grid��$��0��.+��� -    ��Name$ ImageBig��$��20q����� *ActualWidth+ �� ElementName$
 grid�� �� Mode$ OneWay=����� *ActualHeight+$
 grid��$ OneWay=�� $��1�� � RowDefinitions �� $	��10* ��� $��50 ��� $	��10* �.+�� $��0��.+��� -    ��Name$ ButtonUp��$	��100��#��[ .���� $��/Resources/arrowUp.jpg��� $��1��.+��� -	   $ 
ButtonBlur��$��35��$
��Blur��$
��Bold"�$��20(�#��[ � $��2��.+��� -
   $ 
ButtonDown��$	��100��#��[ .���� $��/Resources/arrowDown.jpg��