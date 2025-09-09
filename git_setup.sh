#!/bin/bash

git init

git add .

git commit -m "Firts commit - Sistema de Inventario UCB C#"

git branch -M main

git push -u origin main

git remote add origin https://github.com/linuxenthusiastic/inventory-system-ucb.git

echo "========================================="
echo "Proyecto subido correctamente"
echo "========================================="
