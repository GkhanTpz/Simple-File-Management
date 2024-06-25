#include <stdio.h>
#include <stdlib.h>
#define MAX_SIZE 50

struct Nation
{
    char name[MAX_SIZE];
    char language[MAX_SIZE];
    char region[MAX_SIZE];
}nation;

struct Citizen
{
    char name_citizen[MAX_SIZE];
    char lastname_citizen[MAX_SIZE];
    int age_citizen;
    struct Nation nation;
}citizen;

void ErrorMsg(const char *error);
void GetCitizenData(struct Citizen *citizen);
void PrintCitizenToFile(const struct Citizen *citizen);

int main()
{
    GetCitizenData(&citizen);
    PrintCitizenToFile(&citizen);

    return 0;
}

void ErrorMsg(const char *error)
{
    printf("%s could not be created...\n", error);
}

void GetCitizenData(struct Citizen *citizen)
{
    printf("Enter Name of Citizen: ");
    scanf("%49s",citizen->name_citizen);
    printf("Enter Last Name of Citizen: ");
    scanf("%49s",citizen->lastname_citizen);
    printf("Enter Age of Citizen: ");
    scanf("%d",&citizen->age_citizen);
    printf("Enter Name of Citizen's Nation: ");
    scanf("%49s",citizen->nation.name);
    printf("Enter Language of Citizen's Nation: ");
    scanf("%49s",citizen->nation.language);
    printf("Enter Region of Citizen's Nation: ");
    scanf("%49s",citizen->nation.region);
}

void PrintCitizenToFile(const struct Citizen *citizen)
{
    FILE *citizenFile = fopen("citizen.txt", "a+b");
    if (citizenFile == NULL)
    {
        errorMsg("citizen.txt");
        printf("File hasn't been read and written...\n");
        exit(1);
    }
    else
    {
        fprintf(citizenFile, "---------------------------------------------------------------\n");
        fprintf(citizenFile, "Name of Citizen                  : %s\n", citizen->name_citizen);
        fprintf(citizenFile, "Last Name of Citizen             : %s\n", citizen->lastname_citizen);
        fprintf(citizenFile, "Age of Citizen                   : %d\n", citizen->age_citizen);
        fprintf(citizenFile, "Name of Citizen's Nation         : %s\n", citizen->nation.name);
        fprintf(citizenFile, "Language of Citizen's Nation     : %s\n", citizen->nation.language);
        fprintf(citizenFile, "Region of Citizen's Nation       : %s\n", citizen->nation.region);
        fprintf(citizenFile, "---------------------------------------------------------------\n");
        printf("File has been read and written...\n");
    }

    fclose(citizenFile);
}
