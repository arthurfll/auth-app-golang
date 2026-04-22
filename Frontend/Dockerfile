FROM nginx:alpine

# Remove config padrão (opcional)
RUN rm -rf /usr/share/nginx/html/*

# Copia todos os arquivos do projeto
COPY . /usr/share/nginx/html

# Expõe a porta 80
EXPOSE 80

# Inicia o nginx
CMD ["nginx", "-g", "daemon off;"]

