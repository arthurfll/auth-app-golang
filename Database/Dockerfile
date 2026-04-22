FROM postgres:17.2-alpine

# Variáveis de ambiente para configuração do PostgreSQL
ENV POSTGRES_DB=db \
    POSTGRES_USER=admin \
    POSTGRES_PASSWORD="Alfa!2025" \
    PGDATA=/var/lib/postgresql/data/pgdata

RUN echo "# Configurações de desenvolvimento" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "listen_addresses = '*'" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "max_connections = 100" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "shared_buffers = 256MB" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "effective_cache_size = 1GB" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "maintenance_work_mem = 64MB" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "checkpoint_completion_target = 0.9" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "wal_buffers = 16MB" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "default_statistics_target = 100" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "random_page_cost = 1.1" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "effective_io_concurrency = 200" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "work_mem = 4MB" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "min_wal_size = 1GB" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "max_wal_size = 4GB" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "log_statement = 'all'" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "log_duration = on" >> /usr/local/share/postgresql/postgresql.conf.sample && \
    echo "log_min_duration_statement = 0" >> /usr/local/share/postgresql/postgresql.conf.sample

RUN echo "host all all 0.0.0.0/0 md5" >> /usr/local/share/postgresql/pg_hba.conf.sample

EXPOSE 5432

VOLUME /var/lib/postgresql/data