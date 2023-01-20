# HackBlock

## Comment tester l'application

Un fichier .apk se trouve sur le disque de l'école. Il suffit de connecter son téléphone à son ordinateur et de transférer le fichier dessus.
Il faut depuis le téléphone cliquer sur le fichier build.apk pour télécharger l'application..
L'application a été faite pour un Samsung A32, il est donc possible que l'affichage ne soit pas optimal sur les autres appareils.

## Comment Build

Afin de pouvoir executer le code il faut cloner le projet sur gitlab (https://gitlab-etu.ing.he-arc.ch/isc/2022-23/niveau-3/3281.1-projet-p3-sa-il/217/hackblock).<br>
Depuis Unity Hub il faut aller dans l'onglet open->add project from disk, afin d'ajouter le projet cloné.<br>
Il faut le lancer depuis Unity Hub, la version de l'éditeur est la 2021.3.8f1. L'importation peut prendre plusieurs minutes.<br>
Une fois l'importation finie depuis Unity, il faut aller dans les Scenes et selectionner MainWindow.<br>
Dans l'onglet Game, il faut changer le Free Aspect en 720x1600 pour que ça corresponde au téléphone utilisé, un Samsung A32.<br>
Les tests sont fonctionnels dans le simulateur en lançant avec le bouton play.<br>

Pour pouvoir build sur son téléphone il faut qu'il ait accès au mode développeur, et de le connecter en filaire.<br>
Depuis l'onglet File, il faut accéder à Build Settings. Il faut changer la plateforme à Android puis cliquer sur le bouton switch Platform. Il faut par la suite sélectionner le téléphone sur lequel on veut build, il est choisi avec la rubrique Run Device.<br>
Il faut ensuite taper le mot de passe dans les Player Settings pour pouvoir faire le build.<br>
Veuillez me contacter par mail (guillaume.mouchet@he-arc.ch) pour que l'on place un rendez-vous que je puisse vous transmettre mes identifiants pour pouvoir build, il est toujours possible d'utiliser le simulateur dans Unity pour tester le jeu ou d'utiliser le fichier .apk sur le disque de l'école.
