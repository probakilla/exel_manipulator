# Exel

Jusqua 5 onglet sur un fichier exel. (5 types d'échanges, entrant (partenaire
vers poset), sortant (inverse), direct (entre partenaires), proxyfiés entrants
(partenaires vers outils poste), proxyfiés sortants))

## structure

- l'ID -> regarder combien de ports concernés pour 1 ID

couple (ip locale, ip internet) est affecté à un couble destination (ip dest, ip
dest internet)

Flux direct iterpartenaire : Nom de la matrice, si source == nom matric : flux
entrant

cases à replire pour le fichier sortant : H I K L O Q S
Si la ligne est en jaune, le flux n'a pas été atteint depuis 1 an au moins. Il
faut garder la couleur.

## Onglets

### Flux direct entrant

| Fichier entrée (Export Matrice) | Fichier sortie (Crible Matrice) |                                 Commentaire                                  |
| :-----------------------------: | :-----------------------------: | :--------------------------------------------------------------------------: |
|         source réelle F         |         source réelle H         |                                                                              |
|            source E             |         Source nattée I         |  Garder l'ip seulement, et le numéro qu'il la suit e.g. XXX.XXX.XXX.XXX_YY   |
|      Destination réelle H       |     IP destination réelle K     |                                                                              |
|          Destination G          |     IP destination nattée L     | Prendre que l'IP (1er nombre entre ()) Onglet Flux Direct Entrant, MIP(XXXX) |
|            Servuce I            |             Port O              |            Transformer protocole en Port si pas port (voir onglet            |

Le nom de l'onglet déternmine la colone Q (Nature de flux) et la colone S (sens
de flux)

### Flux direct Sortant

|        Entrée        |         Sortie          | Commentaire |
| :------------------: | :---------------------: | :---------: |
|   Source réelle F    |     Source réelle H     |             |
|       Source E       |     Source nattée I     |    Idem     |
| Destination réelle H | IP destination réelle K |             |
|    Destination G     | IP destination nattée L |    Idem     |
|      Service I       |         Port O          |    Idem     |

Le nom de l'onglet déternmine la colone Q (Nature de flux) et la colone S (sens
de flux)

### Flux Direct inter-partenaire

|        Entrée        |         Sortie          | Commentaire |
| :------------------: | :---------------------: | :---------: |
|   Source réelle G    |     Source réelle H     |             |
|       Source E       |     Source nattée I     |    Idem     |
| Destination Réelle J | IP destination Réelle K |             |
|    Destination H     | Ip destination nattée L |    Idem     |
|      Service K       |         Port O          |    Idem     |

Si l'onglet == Flux direct inter-partenaire : remplir colonne Q avec le nom de
la colonne.

Dans la colonne source, si le premier nombre de la colonne E correspond au
nombre de ligne 1 -> Flux sortant, sinon entrant.

Dans la colonne Y (du fichier sortant), Mettre le premier nombre de la colonne
source (E) avec le premier nombre de la colonne destination (H) e.g.
> Flux Interpartenaires XXXX - YYYY

### Flux proxifiés entrants

|           Entrée            |       Sortie       |           Commentaire            |
| :-------------------------: | :----------------: | :------------------------------: |
|       Règle source D        | IP source nattée I |                                  |
| Règle - Destination E (URL) |     URL ... M      |                                  |
|       Règle - Port C        |       Port O       |      Rajouter 'TCP_' devant      |
|            RIEN             |  Nature du flux Q  | copier : "Flux proxifié Pasi V2" |
|            RIEN             |   Sens du flux S   |        copier : "Entrant"        |

### Flux proxifié sortant

|           Entrée            |      Sortant       |           Commentaire            |
| :-------------------------: | :----------------: | :------------------------------: |
|       Règle source D        | IP source nattée I |                                  |
| Règle - Destination E (URL) |     URL ... M      |                                  |
|       Règle - Port C        |       Port O       |      Rajouter 'TCP_' devant      |
|            RIEN             |  Nature du flux Q  | copier : "Flux proxifié Pasi V2" |
|            RIEN             |   Sens du flux S   |        copier : "Sortant"        |
