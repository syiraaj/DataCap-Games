   M S B A M L   `   `   `  ����B  >DataCap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DataCapDataCap  5   	       DataCap.Task1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:DataCap     5   	     � Title$
  Task��5   	   $��433.075��6   $	��482��6'    � 	Resources 5	         KinectBlueBrush �� Color  KinectPurpleBrush �� 
TargetType  ScreenshotButton �� Property �� Value �� 
TargetType �� Orientation ��Name	 �� TextAlignment
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 #     &	 F     7  7   �� 5
   
   $ 	#ff00BCF2��62   �� 5   
   $ 	#ff52318f��64   �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ 
Horizontal=�6)   
������ .+�5   "   �� $ ScreenshotText��6,   #��z��6D   $
	 Left=�6e   $��Center=�6{   8��  $��15(�6�   � 5   "   $��9,0,0,0q�6'   .+�5   &   �� $
 ScreenshotNormal��6,   $��ScreenshotNormal.png��6F   $
��None=�6d   $��Center=�6s   �� 5   &   $
 ScreenshotHover��6,   $��ScreenshotHover.png��6E   $
��None=�6b   $��Center=�6q   $y�	Collapsed=�6�   5   #   5      5       5      P� 5       �@J�IsMouseOver . . �5   "   �� $ ScreenshotNormal��6Q    � y�$ 	Collapsed=�6?   6Q   �� 5   "   $ ScreenshotHover��6O    � y�$ Visible=�6?   6O   �� 5   "   8  $ ScreenshotText��6h    � ��5      5       5"      5#      5$      .��5&      � -   5        $��grid1��5&      .+�5'   
   �� -   5         ��Name$ label��5'      $��
PlayerID :��6   $
��Left=�64   $��	19,22,0,0q�6O   $	��Top=�6b   $��Bell MT)�6z   $��16(�6�   �� 5(   
   -   5        $ label1��5(      $��Name :��6    $
��Left=�61   $��	19,52,0,0q�6L   $	��Top=�6_   $��Bell MT)�6w   $��16(�6�   �� 5)   
   -   5        $ 	textBlock��5)      $
��Left=�6'   $��146,199,0,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��Bell MT)�6�   $��48(�6�   $	��215��6�   $��57��6�   �� 5*   
   -   5        $ 
textBlock1��5*      $
��Left=�6(   $��
102,22,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   $	��180��6�   $��30��6�   $��Bell MT)�6�   $��16(�6�   �� 5+   
   -   5        $ 
textBlock2��5+      $
��Left=�6(   $��
102,52,0,0q�6C   $
��Wrap=�6W   $	��Top=�6k   $	��180��6�   $��28��6�   $��Bell MT)�6�   $��16(�6�   �� 5,   
   -   5        $ 
textBlock3��5,      $��Center=�6(   $��
71,85,43,0q�6E   $
��Wrap=�6Y   $	��Top=�6m   $��Bell MT)�6�   $��48(�6�   $	��360��6�   �� 5-   
   -   5         ��Name$ button1��5-      $��View Result��6"   $
��Left=�68   $��221,345,0,0q�6S   $	��Top=�6h   $	��104��6�   $��Bell MT)�6�   $��16(�6�   $��32��6�   6�   �� 5.   
   -	   5        $ 
textBlock4��5.      $��197,149,0,0q�6(   $
��Wrap=�6=   $��in��6Q   $��Bell MT)�6[   $��48(�6p    J� RenderTransformOrigin$ 0.157,-0.047&�6~   $	��115��6�   $	��Top=�6�   $
��Left=�6�   �� 5/   
   -
   5        $ button2��5/      $��Close��6"   $
��Left=�62   $��343,345,0,0q�6M   $	��Top=�6b   $	��104��6z   $��Bell MT)�6�   $��16(�6�   $��32��6�   6�   50      51      