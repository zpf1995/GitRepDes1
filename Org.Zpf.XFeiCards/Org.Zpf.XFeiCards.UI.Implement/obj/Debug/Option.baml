   M S B A M L   `   `   `  ����Y  UOrg.Zpf.XFeiCards.UI.Implement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Org.Zpf.XFeiCards.UI.ImplementOrg.Zpf.XFeiCards.UI.Implement  5   	   +    %Org.Zpf.XFeiCards.UI.Implement.Option   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Org.Zpf.XFeiCards.UI.Implement     5   	     � Title$  Option��5   	   $	��345��6   $	��434��6%    � 
ResizeMode$ NoResize=�61   .��5	      �  � RowDefinitions 5
   
   �� 5      $��58 �6   �� 5      $��20 �6   �� 5      �� 5      $��42 �6   .+�5   
   �� $��0��6   ���#C40D42.+�5      �� $��.\Images\Banner.png��6   $��UniformToFill=�61   
 �� Top$ 0��6I    �� Left$ 0��6X   $��56��6h   6v   �� 5       �� Right$ 10��6   $ 15��6&   $��Options��66   ���	#FFF3CED9$
��Bold"�6_   $��Microsoft PhagsPa)�6q   $��18(�6�   6�   5      �� 5   
   $��1��6   
���   � � 	Resources 5      4   .Org.Zpf.XFeiCards.UI.Implement.ComboxItemValue   ComboxItemData��%   &	          5      6(   5      .+�5      �� $��2��6   $	��214��6*   $	��427��67   $��1��6C   .@�5      �� $
��Game��6   .��5      � .+�5      �� -   5        $��playGame��5   �   $��play against Computer!��6#   $
��Left=�6D   $	��Top=�6_   $��	11,40,0,0q�6w   $��3��6�    d� 	IsChecked 6�   ��  �� Path$ 
IsCheckBox�6�   �� 5      $	��Top=�6    $
��Left=�68   $��	11,60,0,0q�6S   $��Number of players:��6f   $��3��6�   6�   �� 5      -   5        $��numberOfPlayer��5   �   $	��Top=�6#   $
��Left=�6;   $��
268,66,0,0q�6V   $��58��6j   $��2��6w   	 �� 
IsEditable	 . {�6�   �� 
 �� ElementName$
 playGame��$ 	IsChecked���6�   ��  �� Source# [   �� SelectedValue 6(  �� $ NumerOfPlayers�5#      5$      5%      �� 5&      $��Computer Player��6   .��5'      � .+�5)      �� $��SKIL LEVEL:��6    $	��Top=�66   $
��Left=�6N   $��10,0,0,0q�6i   $��2��6{   6�   	� 5*      -   5        $��DumbRadioButton��5*   �   $
��Dumb��6&   $	��Top=�65   $
��Left=�6M   $��
104,41,0,0q�6h   $
 TrueY�6|   $��1��6�   6�   	� 5+      -   5        $��GoodRadioButton��5+   |   $
��Good��6&   $	��Top=�65   $
��Left=�6M   $��
104,71,0,0q�6h   $��1��6�   6�   	� 5,      -   5        $��CheatsRadioButton��5,      $��Cheats��6&   $	��Top=�67   $
��Left=�6O   $��104,101,0,0q�6j   $��1��6�   6�   5-      5.      51      52      �� 53   
   $��3��6   .+�54      �� -   5        $��cancelButton��54   a   $ 10��6    �� Bottom$ 8��6'   $��75��69   $��20��6D   $��Cancel��6P   6�   �� 55      -   5        $��okButton��55   ]   $ 95��6   $ 8��6'   $��75��69   $��20��6D   $��OK��6P   6�   56      57      58      