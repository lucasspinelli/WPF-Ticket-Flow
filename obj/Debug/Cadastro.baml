   M S B A M L   `   `   `  ����B  >Boletas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BoletasBoletas  5   	       Boletas.Cadastro   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Boletas     5   	     � Title$  Cadastro��5   	   $	��450��6   $��330.055��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��0* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF858585��6    � Offset$ 1Q�61   � 5      $ 	#FF242524��6   5      .+�5   
   �� $��Usuário��6   $
��Left=�6"   $��
117,65,0,0q�6=   $	��Top=�6Q   $��37��6i   $��80��6u   $��18(�6�   $
��Bold"�6�   ���	#FFFBF5F56�   �� 5   
   $��Senha��6   $
��Left=�6    $��117,156,0,0q�6;   $	��Top=�6P   $��37��6h   $��80��6t   $��18(�6   $
��Bold"�6�    J� RenderTransformOrigin$ 0.653,-1.108&�6�   
�������6�   �� 5   
   -   5        $
��Left=�5      $��33��6-   $��
29,107,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��256��6y   ��6�   �� *login+�� 5   
   $
��Left=�6   $��
29,198,0,0q�6-   $	��Top=�6A   $	��256��6Y   $��33��6e   ��6q   �� *senha+�� 5   
   -   5        $��	Cadastrar��5   %   $
��Left=�69   $��
83,309,0,0q�6T   $	��Top=�6h   $	��147��6�   $��41��6�   $��16(�6�   $��Verdana)�6�   $
��Bold"�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FFD3D4D3��6#   $ 0Q�65   � 5      $ 	LimeGreen��6#   $ 1Q�65   5      5      �� 5    
   $��Cancelar��6   $
��Left=�6$   $��
95,369,0,0q�6?   $	��Top=�6S   $	��120��6k   $��25��6w    �� IsCancel . ��5!      �� 5"      $ 0.5,1&�6&   $ 0.5,0&�67   .��5#      � $ 	#FFBDBCBC��6#   $ 0Q�65   � 5$      $ Tomato��6#   $ 1Q�62   5%      5'      �� 5(   
   -   5        $��Perfil��5(      $
��Left=�6#   $��
95,262,0,0q�6>   $	��Top=�6R   $	��120��6j   	 �� Text	 6v   �� *perfil+5)      5*      