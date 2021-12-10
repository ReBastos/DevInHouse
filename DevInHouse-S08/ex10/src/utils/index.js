export function handleGenerateBg (type) {
    const types = {
        grass: '#48D0B0',
        fire: '#FF0000',
        water: '#0000FF'
    }

    return types[type] || '#CCC';
}