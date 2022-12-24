//< 初めに >
// 大当たり = 12%
// 当たり = 48%
// です

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(void)
{
    int i;
    int save;

    srand((unsigned int)time(NULL)); //乱数の規則性防止

    for (i = 0; i < 3; i++) //自由に書き換えてください。
    {
        save=("%d\n", 0 + rand() % 25); //乱数を設定
        if(save < 3)
        {
            printf("大当たり!\n");
        }
        else
        {
            if(save < 12)
            {
                printf("当たり!\n");
            }
            else
            {
                printf("外れ...\n");
            }
            
        }
        
    }


    return 0;
}