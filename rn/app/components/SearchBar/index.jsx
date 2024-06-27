import { Text, TextInput, TouchableOpacity, View } from "react-native"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
    faSearch
} from '@fortawesome/free-solid-svg-icons';
const SearchBar = ({
    value,
    placeholder,
    handleChange,
    search
}) => {
    return (
        <View className="flex border flex-row items-center h-14 px-4 rounded-lg" >
            <TextInput
                className="flex-1 font-semibold text-base"
                value={value}
                placeholder={placeholder}
                onChangeText={handleChange}
            />
            <TouchableOpacity onPress={search}>
                <FontAwesomeIcon icon={faSearch} />
            </TouchableOpacity>
        </View>

    )
}

export default SearchBar