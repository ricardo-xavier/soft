#include <stdio.h>
#include <string.h>

static char *COM_ACENTUACAO = "·ÈÌÛ˙„ı‚ÍÙ‡Á¡…Õ”⁄√’¬ ‘¿«";
static char *SEM_ACENTUACAO = "aeiouaoaeoacAEIOUAOAEOAC";
static char buf[256];

char *tira_acentos(char *s) {
    char *p, *ret=buf;
    for (p=s; *p; p++) {
        char *q = strchr(COM_ACENTUACAO, *p);
        if (q != NULL) {
            int pos = (int) (q - COM_ACENTUACAO);
            *ret++ = SEM_ACENTUACAO[pos];
        } else {
            *ret++ = *p;
        }
    }
    *ret = 0;
    return buf;
}

DECLARE EXTERNAL FUNCTION tira_acentos
    CSTRING(255)
    RETURNS CSTRING(255)
    ENTRY_POINT 'tira_acentos' MODULE_NAME 'soft_udf';

