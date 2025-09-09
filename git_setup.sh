#!/bin/bash

# Inicializar repositorio git
git init

# Agregar todos los archivos
git add .

# Hacer commit inicial
git commit -m "Firts commit - Sistema de Inventario UCB C#"

# IMPORTANTE: Reemplaza [TU_USUARIO] con tu usuario de GitHub
# y [NOMBRE_REPO] con el nombre que quieras para tu repositorio
echo ""
echo "========================================="
echo "INSTRUCCIONES PARA SUBIR A GITHUB:"
echo "========================================="
echo ""
echo "1. Ve a https://github.com/new y crea un nuevo repositorio"
echo "2. NO inicialices el repositorio con README, .gitignore o licencia"
echo "3. Después de crear el repositorio, ejecuta estos comandos:"
echo ""
echo "git remote add origin https://github.com/linuxenthusiastic/inventory-system-ucb.git"
echo "git branch -M main"
echo "git push -u origin main"
echo ""
echo "========================================="
echo "Tu proyecto ya está listo para subir!"
echo "========================================="
