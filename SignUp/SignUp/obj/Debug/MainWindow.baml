   M S B A M L   `   `   `  ����A  =SignUp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SignUpSignUp  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       SignUp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:SignUp     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   0sys&clr-namespace:System;assembly=mscorlib  5   	   -   5          � Title$  
MainWindow��5
   	   $	��600��5   	   $	��500��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency . 
������    SignUpVM � DataContext# [  5   	    � 	Resources 5        
clrPrimary �� Color �� 
TargetType  textboxStyle % !MaterialDesignFloatingHintTextBox	 �� BasedOn
 �� Property �� Value  pwdBoxStyle ) %MaterialDesignFloatingHintPasswordBox'  !MaterialDesignThemes.Wpf.PackIcon  	styleIcon  borderStyle��%�  &	       &	 #     7  7  &	     7  7  &	 �    7  &	 }    7  �� 5   
   $ 	#FF35A0FE��6-   �� 5   
   " ��6   8	   .�5      �� 
 � ��8  6,   �� 5      
 �@��AcceptsReturn . 6.   �� 5      
 � ��$	 333��6&   �� 5      
 � ��$ 14(�6)   �� 5      
 � ��$ 8 0 8 8q�6(   5      �� 5   
   " G�6   8	   .�5       �� 
 � ��$	 333��6&   �� 5!      
 � ��8  6,   �� 5"      
 � ��$ 14(�6)   �� 5#      
 � ��$ 8 0 8 8q�6(   5$      �� 5&   
   "  6   .�5'      �� 
 � ��$ 20��6'   �� 5(      
 � ��$ 40��6&   �� 5)      
 � ��$ Center=�62   �� 5*      
 � ��8   6+   5,      �� 5.   
   " ��6   .�5/      �� 
 � ��$ 1q�60   �� 50      
 � ��8   6,   �� 51      
 �@��CornerRadius$ 5��6-   �� 52      
 � ��$ 0 0 5 0q�6'   53      54      .��55      � -   5         �Name$ 	main_grid��55       � RowDefinitions 56   
   �� 57      $��70 �6   6*   �� 58      6   .+�5:   
   ��  �� CornerRadius$ 10��6   $��2��6#   
�������64   � 5;   
   $��0��6   .+�5<      �� $ 	10 10 0 0��6   ��5=      �� 5>      .��5?      �  � Color$ #08AEEA��6'    � Offset$ 0Q�67   � 5@      $ #2AF598��6'   $ 1Q�67   5A      5C      �� 5D      $��Center=�5E      $��Center=�5F      
�������$��20(�5H      $��Inter)�6'   $��DemiBold"�5I      
ĐĂNG KÝ5K      5L      �� 5N   
   $��1��6   $��60 50q�6"   .+�5O      ��  �� Orientation$ 
Horizontal=�6   .+�5P      �� -   5         ��Name$ txbHo��5P      #��[ 5Q      $	��185��5R      $
��Left=�5S      $��0 0 10 0q�5T      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Họ��5U      ��5V      �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5X      -   5        $ txbTen��5X      #��[ 5Y      $	��185��5Z      $��Right=�5[      $
 Tên��5\      ��5]      �� *
LastName+$ PropertyChanged=�5^      �� 5_      $ 
Horizontal=�6   $��0 16 0 0q�62   .+�5`      �� #��[ 6   ._�5a           Kind$ Account=�6.   #��[ 6=   5b      �� 5c      -   5        $ txbTenDangNhap��5c      #��[ 5d      $ Tên đăng nhập��5e      5g      �� 5h      $ 
Horizontal=�6   $��0 16 0 0q�62   .+�5i      �� #��[ 6   ._�5j        $ Email=�6.   #��[ 6;   5k      �� 5l      -   5        $ txbEmail��5l      #��[ 5m      $ E-mail��5n      5p      �� 5q      $ 
Horizontal=�6   $��0 16 0 0q�62   .+�5r      �� #��[ 6   ._�5s        $
 Lock=�6.   #��[ 6:   5t      G� 5u      -   5         G�Name$ 
txbMatKhau��5u      #��[ 5v      $ Mật khẩu��5w      5y      �� 5z      $ 
Horizontal=�6   $��0 16 0 0q�62   .+�5{      �� #��[ 6   ._�5|        $ LockOpen=�6.   #��[ 6>   5}      G� 5~      -   5        $ txbNhapLaiMatKhau��5~      #��[ 5      $ Nhập lại mật khẩu��5�      5�      �� 5�      $ 
Horizontal=�6   $��0 16 0 0q�62   .+�5�      �� #��[ 6   ._�5�        $ Calendar=�6.   #��[ 6>   5�      (  "System.Windows.Controls.DatePicker  5�      -	   5          Name$ txbNgaySinh��5�      $	��333��5�      $ 
Ngày sinh��5�      ���	#FF35A0FE$��14(�5�      $��8 0 8 8q�5�       ( $MaterialDesignFloatingHintDatePicker#��[ 5�      5�      �� 5�      $ 
Horizontal=�6   $��Center=�62   $��0 30 0 0q�6O   .+�5�      �� $��HUỶ��6    %	 !MaterialDesignOutlinedLightButton#��[	 5�      $��0 0 10 0q�5�      $��50��5�      $	��100��5�      �� 5�      $��
ĐĂNG KÝ��6    #
 MaterialDesignFlatLightBgButton#��[
 5�      $��50��5�      $	��100��5�      ��5�      �� *ValidationSignUpCommand+5�      5�      5�      5�      