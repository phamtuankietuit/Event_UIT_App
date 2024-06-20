import { Image, Text, TouchableOpacity, View } from "react-native"
import logo from "../../assets/images/Logo.png"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
    faEllipsis,
} from '@fortawesome/free-solid-svg-icons';
const Post_Item = (
    {
        item,
    }
) => {
    return (
        <View className="bg-white flex w-[97%] my-2 rounded-lg mx-2 p-3">
            <View className="flex flex-row h-[70px] justify-center ">
                <View className="w-[20%] flex items-center">
                    <Image
                        source={logo}
                        className="bg-white rounded-full w-[75%] h-[75%] me-4 "
                        resizeMode="contain"
                    />
                </View>
                <View className="w-[70%]">
                    <Text className="text-[18px] font-semibold mb-2">{item.namePage}</Text>
                    <Text>10h trước</Text>
                </View>
                <View className="w-[10%] flex items-center">
                    <TouchableOpacity>
                        <FontAwesomeIcon icon={faEllipsis} color="#64748b" />
                    </TouchableOpacity>

                </View>
            </View>
            <View>
                <Text className="px-3" numberOfLines={2}>
                    {item.content}
                </Text>
                <TouchableOpacity className='px-3 mb-7'>
                    <Text className='text-blue-500'>Xem thêm ...</Text>
                </TouchableOpacity>
                <View className="flex flex-row items-center flex-wrap gap-3">
                    {
                        item.images.map((item, index) => (
                            <Image
                                key={index}
                                source={logo}
                                className="w-[30%] h-[100px]"
                                resizeMode="contain"
                            />
                        ))
                    }

                </View>

            </View>
            <View className='flex flex-row justify-center items-center'>
                <Text >145 người đã tham gia</Text>
            </View>
            <View className="bg-slate-300 h-[1px] w-[100%] my-2" />
            <View className='flex flex-row justify-center items-center'>
                <TouchableOpacity className='rounded-2xl w-[60%] bg-blue-500 py-3 px-3 my-3 flex justify-center items-center'>
                    <Text className='text-white'>Tham gia sự kiện</Text>
                </TouchableOpacity>
            </View>

        </View>
    )
}

export default Post_Item