   M S B A M L   `   `   `  ����A  =Task 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:asasdaasasda  5   	       Task_3.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:asasda     5   	     � Title$  
MainWindow��5   	   $	��800��6   $	��800��6)   .��5	      � $
��Left=�6   $	��800��6&    J� RenderTransformOrigin$ 0.494,0.761&�62   .+�5
   
   �� $��1��6   
����ح�.@�5      �� $��Expenses��6   .��5      �� .+�5      �� -   5         ��Name$ labelIncome��5      $��Enter Income��61   $
��Left=�6H   $��	20,46,0,0q�6c   $	��Top=�6v   $	��103��6�   $��26��6�   �� 5      -   5         ��Name$ 	incomeTxt��5      $
��Left=�61   $��	20,77,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��148��6�   $��21��6�   6�   �� 5      -   5        $ labelTaxDeduction��5      $��Income tax Deduction��67   $
��Left=�6V   $��
20,109,0,0q�6q   $	��Top=�6�   $��26��6�   $	��126��6�   �� 5      -   5        $ 	incometax��5      $
��Left=�61   $��
20,140,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5      -   5        $ grocery��5      $��Enter Grocery Expense��6-   $
��Left=�6M   $��
20,172,0,0q�6h   $	��Top=�6|   $��26��6�   $	��128��6�   �� 5      -   5        $ 
grocerytxt��5      $
��Left=�62   $��
20,221,0,0q�6M   $
 Wrap=�6a   $	��120��6u   $��18��6�   $	��Top=�6�   �� 5      -   5        $ 
waterLight��5      $��Water and Light Expenses��60   $��
20,254,0,0q�6S   $	��Top=�6g   $ 0.144,0.501&�6   $
��Left=�6�   $	��146��6�   $��26��6�   �� 5      -   5        $ lightandwatertxt��5      $
��Left=�68   $��
20,294,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5      -	   5        $ travel��5      $��Travel Expenses��6,   $
��Left=�6F   $��
26,328,0,0q�6a   $	��Top=�6u   $ 0.118,-1.382&�6�   $��26��6�   $��92��6�   �� 5      -
   5        $ 	traveltxt��5      $
��Left=�61   $��
20,373,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5      -   5        $ phone��5      $'��!Cell Phone and Telephone Expenses��6+   $
��Left=�6W   $��
20,398,0,0q�6r   $	��Top=�6�   $ 0.223,-1.326&�6�   $��26��6�   $	��200��6�   �� 5      -   5        $ cellphonetxt��5      $
��Left=�64   $��
20,448,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5      -   5        $ other��5      $��Other Expenses��6+   $
��Left=�6D   $��
20,483,0,0q�6_   $	��Top=�6s   $ 0.118,-2.666&�6�   $��26��6�   $��92��6�   �� 5      -   5        $ othertxt��5      $
��Left=�60   $��
20,530,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   	� 5      -   5         	�Name$ rentProperty��5   "    	� 	GroupName$ 	RentorBuy��68   $��Rent Property��6N   $
��Left=�6f   $��
225,25,0,0q�6�   $	��Top=�6�    �� 	ClickMode$ Release=�6�   $��14(�6�   6�   	� 5      -   5        $ buyProperty��5   "   $ 	RentorBuy��67   $��Buy Property��6M   $
��Left=�6d   $��
341,25,0,0q�6   $	��Top=�6�   $ Press=�6�   $��14(�6�   6�   �� 5      -   5        $ propertyPrice��5      $$��Choose from Above radio button��63   $
��Left=�6\   $��
234,45,0,0q�6w   $	��Top=�6�   $ 0.621,15.625&�6�   $��26��6�   $	��216��6�   �� 5      -   5        $ propertyPricetxt��5      $
��Left=�68   $��
233,74,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��154��6�   �� 5      -   5        $ depositLabel��5      $��Enter Deposit Amount��62   $
��Left=�6Q   $��234,109,0,0q�6l   $	��Top=�6�   �� 5       -   5        $ depositAmountTxt��5       $
��Left=�68   $��234,140,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��153��6�   �� 5!      -   5        $ interestRate��5!      $��Enter Interest Rate��62   $
��Left=�6P   $��234,172,0,0q�6k   $	��Top=�6�   $��24��6�   �� 5"      -   5        $ interestRateTxt��5"      $
��Left=�67   $��233,221,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��153��6�   �� 5#      -   5        $ monthsLabel��5#      $9��3Enter Numer of Months (240 - 360) for Repaying loan��61   $
��Left=�6o   $��233,256,0,0q�6�   $	��Top=�6�   $��36��6�   $	��294��6�   �� 5$      -   5        $ propertyMonthstxt��5$      $
��Left=�69   $��234,297,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   	� 5%      -   5        $ buyCar��5%   "   $��Buy Car��62   $
��Left=�6D   $��
543,21,0,0q�6_   $	��Top=�6s   $��14(�6�   $ Press=�6�   $��75��6�   	� 5&      -   5        $ noCarButton��5&   "   $��No Car��67   $
��Left=�6H   $��
646,21,0,0q�6c   $	��Top=�6w   $��14(�6�   $��70��6�   �� 5'      -   5        $ carModel��5'      $��Car Make and Model��6.   $
��Left=�6K   $��
543,46,0,0q�6f   $	��Top=�6z   $	��136��6�   �� 5(      -   5        $ carmodeltxt��5(      $
��Left=�63   $��
545,78,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��171��6�   �� 5)      -   5        $ carPriceLabel��5)      $��	Car Price��63   $
��Left=�6G   $��543,103,0,0q�6b   $	��Top=�6w   $��64��6�   �� 5*      -   5        $ carPricetxt1��5*      $
��Left=�64   $��544,135,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��173��6�   �� 5+      -   5        $ 
depositcar��5+      $��Deposit Amount��60   $
��Left=�6I   $��545,172,0,0q�6d   $	��Top=�6y   $	��109��6�   �� 5,      -    5        $ depositCartxt��5,      $
��Left=�65   $��545,221,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��173��6�   �� 5-      -!   5        $ interesteratelbl��5-      $��Interest rate��66   $
��Left=�6N   $��545,261,0,0q�6i   $	��Top=�6~   $��83��6�   �� 5.      -"   5        $ carInteresteRatetxt��5.      $
��Left=�6;   $��545,295,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��169��6�   $ 0.5,0.5&�6�   6�   �� 5/      -#   5        $ insurancelbl��5/      $��Premium Insurance amount��62   $
��Left=�6U   $��544,310,0,0q�6p   $	��Top=�6�   $	��176��6�   �� 50      -$   5        $ insuranceAmounttxt��50      $
��Left=�6:   $��544,364,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��173��6�   �� 52      -%   5         ��Name$ OutputBlock��52       $
��Left=�65   $��225,398,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $	��174��6�   $	��337��6�   �� 53      -&   5        $��Calculate My Expenses��53      $
��Left=�6=   $��603,488,0,0q�6X   $	��Top=�6m   $ 
0.39,0.374&�6�   $��38��6�   $	��123��6�   z�54      V� 55      .~�56   "   �� �� 57   "   �� 58   "   	 �� Angle$	 -0.124Q�62   T� 59   "   
 T� X$
 -0.029Q�65    T� Y$ 0.028Q�6@   5:      5<      5=      5>      �� 5?      $��Saving��6   .��5@      �� .+�5A      �� -'   5        $ 
purposeLbl��5A      $��
Saving For��60   $
��Left=�6E   $��	20,40,0,0q�6`   $	��Top=�6s   �� 5B      -(   5        $ 
purposetxt��5B      $
��Left=�62   $��	20,70,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5C      -)   5        $ 	amountlbl��5C      $��Total Saving Amount��6/   $
��Left=�6M   $��
20,100,0,0q�6h   $	��Top=�6|   �� 5D      -*   5        $ savingAmounttxt��5D      $
��Left=�67   $��
20,140,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5E      -+   5        $ timelbl��5E      $��Time Period (in years)��6-   $
��Left=�6N   $��
20,170,0,0q�6i   $	��Top=�6}   �� 5F      -,   5        $ timetxt��5F      $
��Left=�6/   $��
20,200,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5G      --   5        $ interestLbl��5G      $��Monthly Interest rate��61   $
��Left=�6Q   $��
20,240,0,0q�6l   $	��Top=�6�   �� 5H      -.   5        $ interestRatetxt��5H      $
��Left=�67   $��
20,270,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5I      -/   5         ��Name$ calculateSaving��5I      $��Calculate Monthly Savings��66   $
��Left=�6Z   $��
20,300,0,0q�6u   $	��Top=�6�   $	��121��6�   $��43��6�   6�   �� 5J      -0   5        $ savingBlock��5J       $
��Left=�65   $��400,200,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��87��6�   $	��357��6�   5K      5L      5M      5O      5P      