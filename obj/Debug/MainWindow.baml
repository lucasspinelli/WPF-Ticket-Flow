   M S B A M L   `   `   `  ����B  >Boletas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BoletasBoletas  5   	       Boletas.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Boletas     5   	     � Title$  Login��5   	   $	��450��6   $��330.055��6$   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��0* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF858585��6    � Offset$ 1Q�61   � 5      $ 	#FF242524��6   5      .+�5   
   �� $��Usuário��6   $
��Left=�6"   $��
117,76,0,0q�6=   $	��Top=�6Q   $��37��6i   $��80��6u   $��18(�6�   $
��Bold"�6�   ���	#FFFBF5F56�   �� 5   
   $��Senha��6   $
��Left=�6    $��117,197,0,0q�6;   $	��Top=�6P   $��37��6h   $��80��6t   $��18(�6   $
��Bold"�6�    J� RenderTransformOrigin$ 0.653,-1.108&�6�   
�������6�   �� 5   
   -   5        $��	TBusuario��5      $
��Left=�6#   $��33��6>   $��
29,130,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��256��6�   ��6�   �� *usuario.login+�� 5   
   -   5        $��TBsenha��5      $
��Left=�6!   $��
29,239,0,0q�6<   $	��Top=�6P   $	��256��6h   $��35��6t   ��6�   �� *usuario.senha+�� 5   
   -   5        $��Logar��5   !   $
��Left=�61   $��
83,309,0,0q�6L   $	��Top=�6`   $	��147��6x   $��41��6�   $��16(�6�   $��Verdana)�6�   $
��Bold"�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FFD3D4D3��6#   $ 0Q�65   � 5      $ 	LimeGreen��6#   $ 1Q�65   5      5      �� 5    
   $��	Cadastrar��6   $
��Left=�5!      $��
95,369,0,0q�5"      $	��Top=�5#      $	��120��5$      $��25��6    �� IsCancel . ��5&      �� ��5'      �� *CommandCadastrar+��5(      �� 5)      $ 0.5,1&�6&   $ 0.5,0&�67   .��5*      � $ 	#FFBDBCBC��6#   $ 0Q�65   � 5+      $ Yellow��6#   $ 1Q�62   5,      5.      50      51      