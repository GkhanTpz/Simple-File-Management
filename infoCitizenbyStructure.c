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

void errorMsg(const char *error);
void getCitizenData(struct Citizen *citizen);
void printCitizenToFile(const struct Citizen *citizen);

int main()
{
    getCitizenData(&citizen);
    printCitizenToFile(&citizen);

    return 0;
}

void errorMsg(const char *error)
{
    printf("%s could not be created...\n", error);
}

void getCitizenData(struct Citizen *citizen)
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

void printCitizenToFile(const struct Citizen *citizen)
{
    FILE *citizen_file = fopen("citizen.txt", "a+b");
    if (citizen_file == NULL)
    {
        errorMsg("citizen.txt");
        exit(1);
    }
    else
    {
        fprintf(citizen_file, "---------------------------------------------------------------\n");
        fprintf(citizen_file, "Name of Citizen                  : %s\n", citizen->name_citizen);
        fprintf(citizen_file, "Last Name of Citizen             : %s\n", citizen->lastname_citizen);
        fprintf(citizen_file, "Age of Citizen                   : %d\n", citizen->age_citizen);
        fprintf(citizen_file, "Name of Citizen's Nation         : %s\n", citizen->nation.name);
        fprintf(citizen_file, "Language of Citizen's Nation     : %s\n", citizen->nation.language);
        fprintf(citizen_file, "Region of Citizen's Nation       : %s\n", citizen->nation.region);
        fprintf(citizen_file, "---------------------------------------------------------------\n");
    }

    printf("File has been read and written...\n");
    fclose(citizen_file);
}
