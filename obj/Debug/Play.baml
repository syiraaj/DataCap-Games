   M S B A M L   `   `   `  ����B  >DataCap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DataCapDataCap  5   	       DataCap.Play   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:DataCap     5   	   -   5          � Title$  Skeletal DataCap��5   	   $��540.741��5	   	   $��749.285��6    � WindowStartupLocation$ CenterScreen=�5   &    � 
ResizeMode$ NoResize=�6K    � 	Resources 5         MediumGreyBrush �� Color  KinectPurpleBrush  KinectBlueBrush �� 
TargetType  ScreenshotButton �� Property �� Value �� 
TargetType	 �� Orientation
 ��Name �� TextAlignment ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 #     &	 F     &	 i     7  7  �� 5   
   $ 	#ff6e6e6e��62   �� 5   
   $ 	#ff52318f��64   �� 5   
   $ 	#ff00BCF2��62   �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $	 
Horizontal=�6)   
������ .+�5   "   �� $
 ScreenshotText��6,   #��z��6D   $
 Left=�6e   $��Center=�6{   8��  $��15(�6�   � 5   "   $��9,0,0,0q�6'   .+�5   &   �� $ ScreenshotNormal��6,   $!��Images\ScreenshotNormal.png��6F   $
��None=�6k   $��Center=�6z   �� 5   &   $ ScreenshotHover��6,   $ ��Images\ScreenshotHover.png��6E   $
��None=�6i   $��Center=�6x   $y�	Collapsed=�6�   5   #   5      5       5      P� 5       �@J�IsMouseOver . . �5   "   �� $ ScreenshotNormal��6Q    � y�$ 	Collapsed=�6?   6Q   �� 5    "   $ ScreenshotHover��6O    � y�$ Visible=�6?   6O   �� 5!   "   8  $ ScreenshotText��6h    � ��5"      5$      5&      5'      5(      .��5)      � $��	10,0,10,8q�6    � RowDefinitions 5*   
   �� 5+      $
��Auto �6   �� 5,      $��* �6   �� 5-      $
��Auto �6   .+�50   
   �� $��0��6   $
��Left=�6   $
��Fill=�68   $��32��6G   $��81��6S   $��0 10 0 5q�6^   �� 51   
   $��0��6   $��0 0 -1 0q�6!   $��Right=�63   $��Bottom=�6O   #��[  6j   $��
Bauhaus 93)�6�   $��26.667(�6�   Skeletal DataCap6�   �� 52   
   $��0��6   $
��None=�6   $��Center=�6,   $��0 0 0 5q�6I   (� 54   
   $��1��6   $��Center=�6   .��55      �� $��UniformToFill=�63   ��6   �� *ImageSource+63   56      �� 58   
   -   5        $��	statusBar��58   ?   $��2��6   $��Stretch=�6!   $��Bottom=�6P   
�������#��[  6~   .@�59      �� $��68��6;   ��6   �� *
StatusText+6;   5:      �� 5;   
   -   5         ��Name$ button��5;      $��Close��6!   $
��Left=�61   $��
595,19,0,0q�6L   $��2��6`   $	��Top=�6m   $	��106��6�   $��30��6�   $��Bell MT)�6�   $��16(�6�   6�   5<      5=      